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

namespace BarkotTakipSistemi.CASE_OPERATİON
{
    public partial class Veresiye : Form
    {
        public Veresiye()
        {
            InitializeComponent();
        }
        ICustomerServices customerServices = new CustomerServices();
        private void Veresiye_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            dataGridView1.DataSource = customerServices.GetAll().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int customerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value);

                var button = (DataGridViewButtonColumn)dataGridView1.Columns[e.ColumnIndex];

                if (button.Name == "Edit")
                {
                    CustomerEdit(customerID);
                }
                else if (button.Name == "Delete")
                {
                    CustomerDelete(customerID);
                }
            }

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int customerID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["CustomerId"].Value);
                CustomerEdit(customerID);

            }

        }

        private void CustomerDelete(int customerID)
        {
            DialogResult dialogResult = MessageBox.Show(customerID + " id'li kategori silinecek! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    customerServices.Delete(customerID);

                    //Silme işlemi tamamlandıktan sonra listeyi güncelliyoruz.
                    LoadCustomer();

                    MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
        }

        private void CustomerEdit(int customerID)
        {
            EditCustomer editCustomer = new EditCustomer(customerID);
            editCustomer.ShowDialog();
            LoadCustomer();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.ShowDialog();
            LoadCustomer();
        }

     
    }
}
