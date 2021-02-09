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

namespace BarkotTakipSistemi.ADMİN_OPERATİON
{
    public partial class EmployeeEdit : Form
    {
        int EmployeeID = 0;
        public EmployeeEdit()
        {
            InitializeComponent();
        }
        public EmployeeEdit(int employeeID)
        {
            InitializeComponent();
            EmployeeID = employeeID;
        }

        IEmployeeServices employeeServices = new EmployeesServices();
        private void btnSave_Click(object sender, EventArgs e)
        {

            Save();
        }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            if (EmployeeID > 0)
            {
                LoadCategory();
            }
        }
        private void LoadCategory()
        {
            var emloyeeDto = employeeServices.GetById(EmployeeID);
            if (emloyeeDto != null)
            {
                txtNameSurname.Text = emloyeeDto.NameSurname.ToString();
                txtUserName.Text = emloyeeDto.Username;
                txtPassword.Text = emloyeeDto.Password;
                txtPhone.Text = emloyeeDto.Phone;
                txtAdress.Text = emloyeeDto.Adress;

            }
        }

        private void Save()
        {
            EmployeeDto employeeDto = new EmployeeDto();
            employeeDto.NameSurname = txtNameSurname.Text;
            employeeDto.Username = txtUserName.Text;
            employeeDto.Password = txtPassword.Text;
            employeeDto.Phone = txtPhone.Text;
            employeeDto.Adress = txtAdress.Text;



            try
            {
                if (EmployeeID > 0)
                {
                    //Güncelleme işlemi gerçekleştirilir
                    employeeDto.EmployeeId = EmployeeID;
                    employeeServices.Update(employeeDto);
                }
                else
                {
                    //Insert işlemi gerçekleştirilir.
                    employeeServices.Add(employeeDto);
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

