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

namespace BarkotTakipSistemi.ADMIN_OPERATION
{
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }
        IEmployeeServices employeeServices = new EmployeesServices();
        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeDto employeeDto = new EmployeeDto();
            employeeDto.NameSurname = txtNameSurname.Text;
            employeeDto.Username = txtUserName.Text;
            employeeDto.Password = txtPassword.Text;
            employeeDto.Phone = txtPhone.Text;
            employeeDto.Adress = txtAdress.Text;

            try
            {

                employeeServices.Add(employeeDto);
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