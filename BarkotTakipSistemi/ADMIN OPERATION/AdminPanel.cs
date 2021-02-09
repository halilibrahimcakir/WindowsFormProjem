using BarkotTakip.Business.Service;
using BarkotTakipSistemi.ADMİN_OPERATİON;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

        }
        private void LoadList()
        {
            dataGridView1.DataSource = employeeServices.GetAll();
        }
        IEmployeeServices employeeServices = new EmployeesServices();
        private void AddUser_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeeServices.GetAll().Where(p => p.NameSurname.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int employeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["EmployeeId"].Value);
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var button = (DataGridViewButtonColumn)dataGridView1.Columns[e.ColumnIndex];

                if (button.Name == "Düzenle")
                {
                    EmployeeEdit(employeeID);
                }
                else if (button.Name == "Delete")
                {
                    EmployeeDelete(employeeID);
                }
            }

        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int employeeID = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["EmployeeId"].Value);
                EmployeeEdit(employeeID);
            }
        }

        private void EmployeeEdit(int employeeID)
        {
            EmployeeEdit adminPanel = new EmployeeEdit(employeeID);
            adminPanel.ShowDialog();
            LoadList();
        }

        private void EmployeeDelete(int employeeID)
        {
            DialogResult dialogResult = MessageBox.Show(employeeID + " id'li kategori silinecek! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    employeeServices.Delete(employeeID);

                    //Silme işlemi tamamlandıktan sonra listeyi güncelliyoruz.
                    LoadList();

                    MessageBox.Show("Silme işlemi başarıyla tamamlandı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu! Hata detayı: \r\ne" + ex.InnerException.InnerException.Message);
                }
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.ShowDialog();
            LoadList();
        }
    }
}
