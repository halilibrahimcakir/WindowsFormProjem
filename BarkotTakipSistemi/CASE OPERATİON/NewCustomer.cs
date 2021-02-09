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

namespace BarkotTakipSistemi.CASE_OPERATİON
{
    public partial class NewCustomer : Form
    {
        int CustomerID = 0;
        public NewCustomer()
        {
            InitializeComponent();
        }
        public NewCustomer(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
        }
        ICustomerServices customerServices = new CustomerServices();
        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomersDto customersDto = new CustomersDto();
            customersDto.NameSurname = txtCustomerName.Text;
            customersDto.Adress = txtCustomerAdress.Text;
            customersDto.Phone = txtCustomerPhone.Text;
            customersDto.IsActive = true;
            customersDto.CreatedBy = Cache.EmployeeId;
            customersDto.CreateDate = DateTime.Now;
            try
            {
                customerServices.Add(customersDto);
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
