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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            txtPw.UseSystemPasswordChar = true;
            txtId.PromptText = "Kullanıcı  Adı giriniz...";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main mainform = new Main();
            mainform.Show();

            Hide();
        }

     

        private void txtPw_Click(object sender, EventArgs e)
        {

        }

        private void chboxShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxPwShow.Checked == true)
            {

                txtPw.UseSystemPasswordChar = false;

            }
            else
                txtPw.UseSystemPasswordChar = true;
        }
    }
}
