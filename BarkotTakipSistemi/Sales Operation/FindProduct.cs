using BarkotTakip.Business.Service;
using BarkotTakipSistemi.CacheManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkotTakipSistemi.SALES_OPERATİON
{
    public partial class FindProduct : Form
    {

        public FindProduct()
        {
            InitializeComponent();
        }
        IProductsServices productsServices = new ProductsServices();
        public int Product_Id
        {
            get; set;
        }
        private void FindProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadProduct();

        }

        private void LoadProduct()
        {
            dataGridView1.DataSource = productsServices.GetAll().ToList();
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
            string productName = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value);

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var button = (DataGridViewButtonColumn)dataGridView1.Columns[e.ColumnIndex];

                if (button.Name == "Ekle")
                {
                    Product_Id = productId;
                    ProductInvoker(productId, productName);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["ProductId"].Value);
                string productName = Convert.ToString(senderGrid.Rows[e.RowIndex].Cells["ProductName"].Value);
                Product_Id = productId;
                ProductInvoker(productId, productName);

            }
        }

        private void ProductInvoker(int productId, string productName)
        {
            DialogResult dialogResult = MessageBox.Show(productName + "Adlı ürün satış listesine eklenecektir ! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Ürün Eklendi...");
                Close();
            }
        }
    }
}
