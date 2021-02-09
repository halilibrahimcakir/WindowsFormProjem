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
    public partial class ProductEdit : Form
    {
        int ProductID = 0;

        public ProductEdit()
        {
            InitializeComponent();
        }
        public ProductEdit(int productID)
        {
            InitializeComponent();
            ProductID = productID;
        }

        IProductsServices productsService = new ProductsServices();
        ICategoriesServices categoriesServices = new CategoriesServices();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            if (ProductID > 0)
            {
                LoadProduct();
            }

        }
        private void LoadProduct()
        {
            List<CategoriesDto> categories = new List<CategoriesDto>();
            var category = categoriesServices.GetAll().ToList();
            foreach (var item in category)
            {
                var sorgu = category.Select(p => new CategoriesDto { CategoryId = item.CategoryId, CategoryName = item.CategoryName }).FirstOrDefault();

                categories.Add(sorgu);
            }

            //dtpExpireDate.Value = new DateTime(
            // dtpExpireDate.Value.Year,
            // dtpExpireDate.Value.Month,
            // dtpExpireDate.Value.Day, 0, 0, 0);

            var productDto = productsService.GetById(ProductID);
            if (productDto != null)
            {

                cmbProductCategories.DataSource = categories;
                cmbProductCategories.DisplayMember = "CategoryName";
                cmbProductCategories.ValueMember = "CategoryId";
                cmbProductCategories.SelectedItem = productsService.GetAll().Where(p => p.ProductId == ProductID).Select(p => p.CategoryId).FirstOrDefault();
                txtProductName.Text = productDto.ProductName.ToString();
                txtProductStock.Text = productDto.StockCount.ToString();
                txtProductInPrice.Text = productDto.InPrice.ToString();
                txtProductSalesPrice.Text = productDto.SalesPrice.ToString();
                if ((bool)productsService.GetAll().Where(p => p.ProductId == ProductID).Select(p => p.IsActive).FirstOrDefault())
                {
                    cmbProductsIsActive.SelectedIndex = 1;
                }
                else
                {
                    cmbProductsIsActive.SelectedIndex = 0;
                }
            }
        }
        private void Save()
        {
            ProductsDto productDto = new ProductsDto();
            productDto.ProductName = txtProductName.Text;
            productDto.StockCount = int.Parse(txtProductStock.Text);
            productDto.InPrice = Convert.ToDecimal(txtProductInPrice.Text);
            productDto.SalesPrice = Convert.ToDecimal(txtProductSalesPrice.Text);
            productDto.CategoryId = Convert.ToInt32(cmbProductCategories.SelectedValue);
            productDto.IsActive = Convert.ToBoolean(cmbProductsIsActive.SelectedItem);
            productDto.ExpirationDate = dtpExpireDate.Value;

            try
            {
                if (ProductID > 0)
                {
                    //Güncelleme işlemi gerçekleştirilir
                    productDto.ProductId = ProductID;
                    productsService.Update(productDto);
                }
                else
                {
                    //Insert işlemi gerçekleştirilir.
                    productsService.Add(productDto);
                }

                MessageBox.Show("Kaydetme işlemi başarıyla tamamlandı...");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu! Hata detayı: \r\n" + ex.Message);
            }


        }
    }

}