using BarkotTakip.Business.Service;
using BarkotTakip.Dto.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkotTakipSistemi.PRODUCT_OPERATION
{
    public partial class ProductManegament : Form
    {
        public ProductManegament()
        {
            InitializeComponent();
        }

        IProductsServices productsServices = new ProductsServices();
        ICategoriesServices categoriesServices = new CategoriesServices();
        private void ProductManegament_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            rdoProductId.Checked = true;
            LoadProduct();
        }

        private void LoadProduct()
        {
            var sorgu = (from p in productsServices.GetAll()
                         join c in categoriesServices.GetAll() on p.CategoryId equals c.CategoryId
                         select new ProductsDto
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             CategoryName = c.CategoryName,
                             StockCount = p.StockCount,
                             InPrice = p.InPrice,
                             SalesPrice = p.SalesPrice,
                             ExpirationDate = p.ExpirationDate,
                             IsActive = p.IsActive,
                         }).ToList();
            var bindingList = new BindingList<ProductsDto>(sorgu);
            dataGridView1.DataSource = bindingList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdoProductId.Checked)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Text, "[^0-9]"))
                {
                    MessageBox.Show("Lütfen geçerli bir ürün ID'si giriniz.");
                    txtSearch.Text = "";
                }
                else
                {
                    if (string.IsNullOrEmpty(txtSearch.Text))
                    {
                        LoadProduct();
                    }
                    else
                    {
                        dataGridView1.DataSource = productsServices.GetAll().Where(p => p.ProductId.ToString() == txtSearch.Text.ToString()).FirstOrDefault();
                    }

                }

            }
            else if (rdoProductName.Checked)
            {

                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    LoadProduct();
                }
                else
                {
                    dataGridView1.DataSource = productsServices.GetAll().Where(p => p.ProductName.ToString() == txtSearch.Text.ToString()).ToList();
                }

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value);
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var button = (DataGridViewButtonColumn)dataGridView1.Columns[e.ColumnIndex];

                if (button.Name == "Edit")
                {

                    ProductEdit(productId);
                }
                else if (button.Name == "Delete")
                {
                    ProductDelete(productId);
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductId"].Value);
                ProductEdit(productId);

            }
        }
        private void ProductEdit(int productId)
        {
            ProductEdit productEdit = new ProductEdit(productId);
            productEdit.ShowDialog();
            LoadProduct();
        }
        private void ProductDelete(int productId)
        {
            DialogResult dialogResult = MessageBox.Show(productId + " id'li kategori silinecek! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    productsServices.Delete(productId);

                    //Silme işlemi tamamlandıktan sonra listeyi güncelliyoruz.
                    LoadProduct();

                    MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductEdit productEdit = new ProductEdit();
            productEdit.ShowDialog();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            NewProduct newProduct = new NewProduct();
            newProduct.ShowDialog();
            LoadProduct();
        }
    }
}
