using BarkotTakip.Business.Service;
using BarkotTakip.Dto.Dto;
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

namespace BarkotTakipSistemi
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();


        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {

            IEmployeeServices employeesServices = new EmployeesServices();
            var login = (from emp in employeesServices.GetAll().Where(p => p.Username == txtId.Text && p.Password == txtPw.Text)
                         select new EmployeeDto
                         {
                             Username = emp.Username,
                             Password = emp.Password,
                             NameSurname = emp.NameSurname,
                             EmployeeId = emp.EmployeeId


                         }).FirstOrDefault();
          
            
            
            if (login != null)
            {
                Cache.NameSurname = login.NameSurname;
                Cache.EmployeeId = login.EmployeeId;
                Main mainform = new Main();
                Hide();
                mainform.Show();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre girildi...");
            }




        }


        private void chboxShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbPwShow.Checked == true)
            {

                txtPw.UseSystemPasswordChar = false;

            }
            else
                txtPw.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

       
    }
}
