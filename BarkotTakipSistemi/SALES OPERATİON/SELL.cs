using BarkotTakip.Business.Service;
using System;
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstwvProductsTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            
            
        }

        private void txtTest_Click(object sender, EventArgs e)
        {
            ProductsService productsServices = new ProductsService();
            var urunler = productsServices.GetById(Convert.ToInt32(txtProducts.Text));
            bool esitlik = productsServices.GetById(Convert.ToInt32(urunler)) != urunler;

            if (esitlik)
            {
                MessageBox.Show("Eşit ");


            }
            else
            {
                MessageBox.Show("Eşit değil");
            }
        }
    }
}
