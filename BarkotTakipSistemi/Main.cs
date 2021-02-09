using BarkotTakipSistemi.ADMIN_OPERATION;
using BarkotTakipSistemi.CacheManager;
using BarkotTakipSistemi.CASE_OPERATİON;
using BarkotTakipSistemi.PRODUCT_OPERATION;
using BarkotTakipSistemi.SALES_OPERATİON;
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
    public partial class Main : Form
    {
      
        public Main()
        {
            InitializeComponent();
            Width = 1246;
            Height = 785;
            costumizeDesing();

           
        }

        private void costumizeDesing()
        {
            pnlCaseSubMenu.Visible = false;
            pnlSalesSubMenu.Visible = false;
            pnlStockSubMenu.Visible = false;
            pnlAdminSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSalesSubMenu.Visible == true)
                pnlSalesSubMenu.Visible = false;
            if (pnlCaseSubMenu.Visible == true)
                pnlCaseSubMenu.Visible = false;
            if (pnlStockSubMenu.Visible == true)
                pnlStockSubMenu.Visible = false;
            if (pnlAdminSubMenu.Visible == true)
                pnlAdminSubMenu.Visible = false;
            

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

    
        private void btnSell_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSalesSubMenu);
        }

        private void btnFastSell_Click(object sender, EventArgs e)
        {

            openChildForm(new SELL());
            hideSubMenu();
            lblPageHeader.Text = "Hızlı Satış";
            lblPageDescription.Text = "Bu ekrandan çok amaçlı satış yapabilirsiniz...";


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            openChildForm(new Iade());
            hideSubMenu();
            lblPageHeader.Text = "İade";
            lblPageDescription.Text = "Bu ekrandan iade ile alakalı işlemlerini yapabilirsiniz.";
        }
        private void btnCase_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCaseSubMenu);
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            openChildForm(new Case());
            hideSubMenu();
            lblPageHeader.Text = "Gelir";
            lblPageDescription.Text = "Bu ekrandan gelir işlemlerini yapabilirsiniz...";
        }

        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            openChildForm(new Veresiye());
            hideSubMenu();
            lblPageHeader.Text = "Veresiye";
            lblPageDescription.Text = "Bu ekrandan veresiye işlemlerini yapabilirsiniz...";
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

            showSubMenu(pnlStockSubMenu);
           
        }
        private void btnProductManegament_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductManegament());
            hideSubMenu();
            lblPageHeader.Text = "Ürün Yönetimi";
            lblPageDescription.Text = "Bu ekrandan ürünlerinizi düzenleyebilirsiniz...";
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Cache.NameSurname.ToString();
        }

        private void btnAdminActions_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAdminSubMenu);

        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            lblPageHeader.Text = "Yönetici Paneli";
            lblPageDescription.Text = "Bu ekrandan çalışanlarınızın bilgilerini düzenleyebilirsiniz...";
            openChildForm(new AdminPanel());
            hideSubMenu();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
