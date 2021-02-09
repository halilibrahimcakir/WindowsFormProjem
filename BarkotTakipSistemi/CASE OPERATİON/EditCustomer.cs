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

namespace BarkotTakipSistemi.CASE_OPERATİON
{
    public partial class EditCustomer : Form
    {
        int CustomerID = 0;
        public EditCustomer()
        {
            InitializeComponent();
        }
        public EditCustomer(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }


        ICustomerServices customerServices = new CustomerServices();
        private void EditCustomer_Load(object sender, EventArgs e)
        {
            if (CustomerID > 0)

                LoadCustomer();

        }

        private void LoadCustomer()
        {

            var customersDto = customerServices.GetById(CustomerID);
            if (customersDto != null)
            {
                txtCustomerName.Text = customersDto.NameSurname;
                txtCustomerAdress.Text = customersDto.Adress;
                txtCustomerPhone.Text = customersDto.Phone;
                txtCustomerWillGive.Text = customersDto.WillGive.ToString();

            }


        }
        private void Save()
        {
            CustomersDto customersDto = new CustomersDto();
            customersDto.NameSurname = txtCustomerName.Text;
            customersDto.Adress = txtCustomerAdress.Text;
            customersDto.Phone = txtCustomerPhone.Text;
            customersDto.WillGive = Convert.ToDecimal(txtCustomerWillGive.Text);
            try
            {
                if (CustomerID > 0)
                {
                    //Güncelleme işlemi gerçekleştirilir
                    customersDto.CustomerId = CustomerID;
                    customerServices.Update(customersDto);
                }
                else
                {
                    //Insert işlemi gerçekleştirilir.
                    customerServices.Add(customersDto);
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