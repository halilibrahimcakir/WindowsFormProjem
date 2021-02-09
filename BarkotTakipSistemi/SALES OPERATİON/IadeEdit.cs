using BarkotTakip.Business.Service;
using BarkotTakip.Business.Services;
using BarkotTakip.Dto.Dto;
using BarkotTakipSistemi.CacheManager;
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

namespace BarkotTakipSistemi.SALES_OPERATION
{
    public partial class IadeEdit : Form
    {
        int OrderID = 0;
        decimal TotalPrice = 0;
        decimal? ChangeGiven = 0;
        public IadeEdit(int orderID, decimal totalPrice)
        {
            InitializeComponent();
            OrderID = orderID;
            TotalPrice = totalPrice;
        }
        IPurchaseOrderServices purchaseOrderServices = new PurchaseOrderServices();
        IPurchaseOrderDetailServices purchaseOrderDetailServices = new PurchaseOrderDetailServices();
        IProductsServices productsService = new ProductsServices();
        public static List<PurchaseOrderDetailDto> GivenProducts = new List<PurchaseOrderDetailDto>();
        private void IadeEdit_Load(object sender, EventArgs e)
        {
            lblOrderIDtext.Text = OrderID.ToString();
            lblOrderTotalPricetext.Text = TotalPrice.ToString() + "TL";
            lblGivenMoneytext.Text = "0 TL";

            dataGridView1.AutoGenerateColumns = false;
            LoadOrderDetail();
        }
        private void LoadOrderDetail()
        {
            var sorgu = (from pod in purchaseOrderDetailServices.GetAll()
                         select new PurchaseOrderDetailDto
                         {
                             PurchaseOrderDetailId = pod.PurchaseOrderDetailId,
                             PurchaseOrderId = pod.PurchaseOrderId,
                             ProductId = pod.ProductId,
                             ProductName = pod.ProductName,
                             Quantity = pod.Quantity,
                             QuantitySumPrice = pod.QuantitySumPrice
                         }).Where(p => p.PurchaseOrderId == OrderID).ToList();

            var bindingList = new BindingList<PurchaseOrderDetailDto>(sorgu);
            dataGridView1.DataSource = bindingList;
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            lblGivenMoneytext.Text = lblOrderTotalPricetext.Text;
            DialogResult dialogResult = MessageBox.Show(OrderID + "numaralı sipariş iade edilicektir ! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                dataGridView1.DataSource = null;
                GivenInvoker();
                Close();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Quantity")
            {
                int productID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProductId"].Value);
                int Quantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantity"].Value);
                var sorgu = (from pod in purchaseOrderDetailServices.GetAll().Where(p => p.PurchaseOrderId == OrderID && p.ProductId == productID)
                             select new {
                                 PurchaseOrderDetailId = pod.PurchaseOrderDetailId,
                                 PurchaseOrderId = pod.PurchaseOrderId,
                                 ProductSumPrice = pod.QuantitySumPrice,
                                 qqQuantity = pod.Quantity,
                             }).ToList().FirstOrDefault();
                if (Quantity <= sorgu.qqQuantity && Quantity > 0)
                {
                    var decreasePrice = productsService.GetAll().Where(p => p.ProductId == productID).Select(p => p.SalesPrice).FirstOrDefault();
                    var editprice = dataGridView1.CurrentRow.Cells["QuantitySumPrice"].Value = decreasePrice * Quantity;
                    if (ChangeGiven.Value == sorgu.ProductSumPrice)
                    {
                        ChangeGiven = 0;
                        ChangeGiven += decreasePrice;
                        lblGivenMoneytext.Text = ChangeGiven.ToString();
                        lblOrderTotalPricetext.Text = (TotalPrice - ChangeGiven).ToString();
                    }
                    else
                    {
                        ChangeGiven += decreasePrice;
                        lblGivenMoneytext.Text = ChangeGiven.ToString();
                        lblOrderTotalPricetext.Text = (TotalPrice - ChangeGiven).ToString();
                    }

                }
                else if (Quantity <= 0)
                {

                    if (Quantity <= 0)
                    {
                        MessageBox.Show("Ürünün adetini 1'den düşük değiştiremezsiniz.. Ürünü silmek için butonları kullanınız.");
                        var editquantity = dataGridView1.CurrentRow.Cells["Quantity"].Value = sorgu.qqQuantity;
                        var editprice = dataGridView1.CurrentRow.Cells["QuantitySumPrice"].Value = sorgu.ProductSumPrice;
                        dataGridView1.CurrentRow.Cells[3].Value = sorgu.qqQuantity;

                        lblGivenMoneytext.Text = (ChangeGiven - (decimal)editprice).ToString();
                        lblOrderTotalPricetext.Text = (TotalPrice - (ChangeGiven - (decimal)editprice)).ToString();

                    }



                }
                else
                {
                    MessageBox.Show("Ürünün adetinden daha fazla değişiklik yapamazsınız");
                    var editquantity = dataGridView1.CurrentRow.Cells["Quantity"].Value = sorgu.qqQuantity;
                    var editprice = dataGridView1.CurrentRow.Cells["QuantitySumPrice"].Value = sorgu.ProductSumPrice;
                    dataGridView1.CurrentRow.Cells[3].Value = sorgu.qqQuantity;
                    lblGivenMoneytext.Text = "0 TL";
                    lblOrderTotalPricetext.Text = TotalPrice.ToString();

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            PurchaseOrderDetailDto purchaseOrderDetailDto = new PurchaseOrderDetailDto();
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int PurchaseOrderDetailId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PurchaseOrderDetailId"].Value);
                int ProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProductId"].Value);
                int Quantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantity"].Value);
                int QuantitySumPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["QuantitySumPrice"].Value);
                int purchaseOrderID = PurchaseOrderDetailId;
                int productid = ProductId;
                int count = Quantity;
                int deletedrowSumprice = QuantitySumPrice;
                purchaseOrderDetailDto.ProductId = productid;
                purchaseOrderDetailDto.Quantity = count;
                purchaseOrderDetailDto.PurchaseOrderDetailId = purchaseOrderID;
                if (GivenProducts.Where(p => p.ProductId == productid).Count() > 0)
                {
                    var qq = purchaseOrderDetailServices.GetById(PurchaseOrderDetailId);
                    qq.Quantity += count;
                    purchaseOrderDetailServices.Update(qq);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                else
                {
                    GivenProducts.Add(purchaseOrderDetailDto);
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                //lblGivenMoneytext.Text = deletedrowSumprice.ToString();
                //lblOrderTotalPricetext.Text = (TotalPrice - deletedrowSumprice).ToString();

            }
            else
            {
                MessageBox.Show("İlk önce bir ürün seçmelisiniz...");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GivenInvoker();
            Close();
        }

        private void GivenInvoker()
        {

            var islem = purchaseOrderServices.GetById(OrderID);
            islem.UpdatedBy = Cache.EmployeeId;
            islem.UpdatedDate = DateTime.Now;
            ProductsDto productsDto = new ProductsDto();
            PurchaseOrderDetailDto purchaseOrderDetailDto = new PurchaseOrderDetailDto();

            var sorgu = purchaseOrderDetailServices.GetAll().Where(p => p.PurchaseOrderId == OrderID).ToList();

            if (dataGridView1.Rows.Count <= 0)
            {
                islem.PurchaseOrderStatusId = 2;
                purchaseOrderServices.Update(islem);
                foreach (var item in sorgu)
                {
                    productsDto.ProductId = sorgu.Select(p => item.ProductId).FirstOrDefault();
                    productsDto.Count = sorgu.Select(p => Convert.ToInt32(item.Quantity)).FirstOrDefault();
                    purchaseOrderDetailServices.Delete(sorgu.Select(p => item.PurchaseOrderDetailId).FirstOrDefault());
                    var stockabout = productsService.GetById(productsDto.ProductId);
                    stockabout.StockCount += productsDto.Count;
                    productsService.Update(stockabout);
                }
            }
            else
            {

                foreach (var item in GivenProducts)
                {
                    var productAbout = productsService.GetById(GivenProducts.Select(p => item.ProductId).FirstOrDefault());
                    productAbout.StockCount += GivenProducts.Select(p => item.Quantity).FirstOrDefault();
                    islem.TotalPrice -= productAbout.SalesPrice;
                    purchaseOrderServices.Update(islem);
                   var deleteProduct = sorgu.Where(p => p.ProductId == item.ProductId).Select(p => item.PurchaseOrderDetailId).FirstOrDefault();
                    purchaseOrderDetailServices.Delete(deleteProduct);
                }

            }
        }

        private void btnAdetDusur_Click(object sender, EventArgs e)
        {
            PurchaseOrderDetailDto purchaseOrderDetailDto = new PurchaseOrderDetailDto();
            if (dataGridView1.SelectedRows.Count > 0)
            {

                int PurchaseOrderDetailId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PurchaseOrderDetailId"].Value);
                int ProductId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProductId"].Value);
                int Quantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Quantity"].Value);
                int QuantitySumPrice = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["QuantitySumPrice"].Value);
                dataGridView1.SelectedRows[0].Cells["Quantity"].Value = Quantity - 1;
                int purchaseOrderID = PurchaseOrderDetailId;
                int productid = ProductId;
                int count = Quantity;
                int deletedrowSumprice = QuantitySumPrice;
                purchaseOrderDetailDto.ProductId = productid;
                purchaseOrderDetailDto.Quantity = count;
                purchaseOrderDetailDto.PurchaseOrderDetailId = purchaseOrderID;
                if (GivenProducts.Where(p => p.ProductId == productid).Count() > 0)
                {
                    var qq = purchaseOrderDetailServices.GetById(PurchaseOrderDetailId);
                    qq.Quantity = count;
                    purchaseOrderDetailServices.Update(qq);
                }
                else
                {
                    GivenProducts.Add(purchaseOrderDetailDto);
                }
                //lblGivenMoneytext.Text = deletedrowSumprice.ToString();
                //lblOrderTotalPricetext.Text = (TotalPrice - deletedrowSumprice).ToString();

            }
            else
            {
                MessageBox.Show("İlk önce bir ürün seçmelisiniz...");
            }


        }

    }



}