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
        }

        private void hideSubMenu()
        {
            if (pnlSalesSubMenu.Visible == true)
                pnlSalesSubMenu.Visible = false;
            if (pnlCaseSubMenu.Visible == true)
                pnlCaseSubMenu.Visible = false;
            if (pnlStockSubMenu.Visible == true)
                pnlStockSubMenu.Visible = false;

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


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCaseSubMenu);
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnVeresiye_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlStockSubMenu);
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            hideSubMenu();
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

        }
    }
}
