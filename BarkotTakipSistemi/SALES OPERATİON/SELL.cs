using BarkotTakip.Business.Service;
using BarkotTakip.Business.Services;
using BarkotTakip.Data.Context;
using BarkotTakip.Data.UnitOfWork;
using BarkotTakip.Dto.Dto;
using BarkotTakipSistemi.CacheManager;
using BarkotTakipSistemi.SALES_OPERATİON;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BarkotTakipSistemi
{
    public partial class SELL : Form
    {
        public SELL()
        {
            InitializeComponent();
            lblProductsPrice.Text = "0 TL";
            dataGridView1.AutoGenerateColumns = false;
            _list = new List<ProductsDto>();
        }
        List<ProductsDto> _list;
        List<ProductsDto> newList;
        DateTime dateTime = DateTime.Now;
        IPurchaseOrderServices purchaseOrderServices = new PurchaseOrderServices();
        IPurchaseOrderDetailServices purchaseOrderDetailServices = new PurchaseOrderDetailServices();
        ICustomerServices customerServices = new CustomerServices();
        IProductsServices productsServices = new ProductsServices();
        ICategoriesServices categoriesService = new CategoriesServices();

        public int ChangedCount
        {
            get; set;
        }
        public bool ChangedCountEdit
        {
            get; set;
        }
        public void SELL_Load(object sender, EventArgs e)
        {

        }
        public void btnNakit_Click(object sender, EventArgs e)
        {
            SiparisTetikle(1, null);
            lblChangeGivenTxt.Text = "0 TL";
            txtReceived.Text = "";
            txtProducts.Focus();

        }
        public void SiparisTetikle(int payment, int? customer)
        {
            if (_list.Count > 0)
            {
                PurchaseOrderDto purchaseOrderDto = new PurchaseOrderDto();
                //purchaseOrderDto.PurchaseOrderId = purchaseOrderServices.GetAll().Max(p => p.PurchaseOrderId) + 1;
                purchaseOrderDto.EmployeeId = Cache.EmployeeId;
                purchaseOrderDto.PaymentTypeId = payment;
                purchaseOrderDto.IsApporeved = true;
                purchaseOrderDto.PurchasePrice = _list.Sum(p => p.InPrice);
                purchaseOrderDto.TotalPrice = _list.Sum(p => p.SalesPrice);
                purchaseOrderDto.CreateDate = dateTime;
                purchaseOrderDto.CreatedBy = Cache.EmployeeId;
                purchaseOrderDto.PurchaseOrderStatusId = 1;
                purchaseOrderDto.CustomerId = customer;
                purchaseOrderServices.Add(purchaseOrderDto);
                //var CreatedDate = purchaseOrderServices.GetAll().Max(p => p.CreateDate);
                //int? id = purchaseOrderServices.GetAll().Where(p => p.CreateDate == CreatedDate).Select(p => p.PurchaseOrderId).FirstOrDefault()


                foreach (var item in _list)
                {
                    PurchaseOrderDetailDto purchaseOrderDetailDto = new PurchaseOrderDetailDto();
                    purchaseOrderDetailDto.PurchaseOrderId = purchaseOrderServices.GetAll().Max(p => p.PurchaseOrderId);
                    purchaseOrderDetailDto.ProductId = _list.Select(p => item.ProductId).FirstOrDefault();
                    purchaseOrderDetailDto.ProductName = _list.Select(p => item.ProductName).FirstOrDefault();
                    purchaseOrderDetailDto.Price = _list.Select(p => item.SalesPrice.Value / item.Count).FirstOrDefault();
                    purchaseOrderDetailDto.Quantity = _list.Select(p => item.Count).FirstOrDefault();
                    purchaseOrderDetailDto.CreatedBy = Cache.EmployeeId;
                    purchaseOrderDetailDto.CreatedDate = dateTime;
                    purchaseOrderDetailDto.QuantitySumPrice = purchaseOrderDetailDto.Price * purchaseOrderDetailDto.Quantity;
                    purchaseOrderDetailServices.Add(purchaseOrderDetailDto);

                    var stock = productsServices.GetById(purchaseOrderDetailDto.ProductId);
                    stock.StockCount -= purchaseOrderDetailDto.Quantity;
                    productsServices.Update(stock);

                }

                if (customer != null)
                {
                    CustomersDto customersDto = new CustomersDto();
                    //var borc = customerServices.GetAll().Where(p => p.CustomerId == customer).Select(p => p.WillGive).FirstOrDefault();
                    var borc = (from p in customerServices.GetAll()
                                select p).Where(c => c.CustomerId == customer).FirstOrDefault();


                    customersDto.Adress = borc.Adress;
                    customersDto.NameSurname = borc.NameSurname;
                    customersDto.Phone = borc.Phone;
                    customersDto.WillGive = borc.WillGive.GetValueOrDefault() + purchaseOrderDto.TotalPrice;
                    customersDto.CustomerId = customer.Value;
                    customerServices.Update(customersDto);

                }

                _list.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                lblProductsPrice.Text = "0 TL";

            }
            else
            {
                MessageBox.Show("Lütfen bir ürün giriniz...");

            }

        }
        public async Task Siparis()
        {

            newList = new List<ProductsDto>();
            newList.AddRange(_list);


            async Task<bool> UserKeepsTyping()
            {

                string txt = txtProducts.Text;
                await Task.Delay(500);
                return txt != txtProducts.Text;

            }
            if (await UserKeepsTyping()) return;

            var urun = (from p in productsServices.GetAll()
                        join c in categoriesService.GetAll() on p.CategoryId equals c.CategoryId
                        select new ProductsDto
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            CategoryName = c.CategoryName,
                            Count = p.Count,
                            SalesPrice = p.SalesPrice,
                            InPrice = p.InPrice

                        }).Where(p => p.ProductId.ToString() == txtProducts.Text).FirstOrDefault();

            if (urun != null)
            {

                if (_list.Where(p => p.ProductId == int.Parse(txtProducts.Text)).Count() > 0)
                {

                    var varOlanUrun = _list.Where(p => p.ProductId == int.Parse(txtProducts.Text)).FirstOrDefault();
                    if (ChangedCountEdit == true)
                    {
                        varOlanUrun.SalesPrice = urun.SalesPrice * varOlanUrun.Count;
                        varOlanUrun.Count += urun.Count - 1;
                        _list.RemoveAll(p => p.ProductId == int.Parse(txtProducts.Text));
                        newList.RemoveAll(p => p.ProductId == int.Parse(txtProducts.Text));
                        _list.Add(varOlanUrun);
                        newList.Add(varOlanUrun);
                        ChangedCountEdit = false;
                    }
                    else
                    {
                        varOlanUrun.SalesPrice += urun.SalesPrice;
                        varOlanUrun.Count += urun.Count;
                        _list.RemoveAll(p => p.ProductId == int.Parse(txtProducts.Text));
                        newList.RemoveAll(p => p.ProductId == int.Parse(txtProducts.Text));
                        _list.Add(varOlanUrun);
                        newList.Add(varOlanUrun);
                    }
                }
                else
                {
                    _list.Add(urun);
                    newList.Add(urun);
                }
                dataGridView1.DataSource = newList;
                lblProductsPrice.Text = _list.Sum(p => p.SalesPrice).ToString();
                txtProducts.Clear();
            }
            else
            {
                txtProducts.Clear();
            }

        }
        private void txtProducts_TextChanged(object sender, EventArgs e)
        {
            txtProducts.Focus();
            if (System.Text.RegularExpressions.Regex.IsMatch(txtProducts.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen geçerli bir ürün ID'si giriniz.");
                txtProducts.Text = "";
            }
            else
            {
                Siparis();
            }
        }
        private void btnKredi_Click(object sender, EventArgs e)
        {
            if (_list.Count > 0)
            {
                SiparisTetikle(2, null);
                lblChangeGivenTxt.Text = "0 TL";
                txtReceived.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün giriniz...");
            }
            txtProducts.Focus();


        }
        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            VeresiyeSat veresiyeSat = new VeresiyeSat();
            if (_list.Count > 0)
            {
                veresiyeSat.ShowDialog();
                if (Cache.Operation == true)
                {
                    SiparisTetikle(3, veresiyeSat.Customerid);
                    lblChangeGivenTxt.Text = "0 TL";
                    txtReceived.Text = "";
                    Cache.Operation = false;
                }

            }
            else
            {
                MessageBox.Show("Lütfen bir ürün giriniz...");
            }
            txtProducts.Focus();

        }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            _list.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            lblProductsPrice.Text = "0 TL";
            lblChangeGivenTxt.Text = "0 TL";
            txtReceived.Text = "";
            txtProducts.Focus();

        }
        private void SELL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNakit.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                btnKredi.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                btnVeresiye.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnİptal.PerformClick();
            }
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (_list.Count > 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtReceived.Text, "[^0-9,]"))
                {
                    MessageBox.Show("Lütfen geçerli bir miktar giriniz.");

                    txtReceived.Text = "";
                }
                else
                {
                    var sorgu = _list.Sum(p => p.SalesPrice);
                    if (txtReceived.Text != null && txtReceived.Text != "")
                    {
                        var txtbox = Convert.ToDecimal(txtReceived.Text);
                        lblChangeGivenTxt.Text = (sorgu - txtbox) + " TL".ToString();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen para üstü giriniz...");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fiyatın hesaplanabilmesi için ürün girilmesi gerekli...");
            }

            txtProducts.Focus();


        }
        private void btnProductFind_Click(object sender, EventArgs e)
        {
            FindProduct findProduct = new FindProduct();
            findProduct.ShowDialog();
            txtProducts.Text = findProduct.Product_Id.ToString();
            txtProducts.Focus();

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Count")
            {
                int changedCount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Count"].Value);
                int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value);
                ChangedCount = changedCount;
                ChangedCountEdit = true;
                txtProducts.Text = productId.ToString();
            }
        }

    }
}
