using BarkotTakip.Business.Service;
using BarkotTakip.Business.Services;
using BarkotTakip.Dto.Dto;
using BarkotTakipSistemi.SALES_OPERATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkotTakipSistemi.SALES_OPERATİON
{
    public partial class Iade : Form
    {
        public Iade()
        {
            InitializeComponent();
        }
        IPurchaseOrderServices purchaseOrderServices = new PurchaseOrderServices();
        IEmployeeServices employeeServices = new EmployeesServices();
        IPurchaseOrderStatusServices purchaseOrderStatusServices = new PurchaseOrderStatusServices();
        IPaymentTypeServices paymentTypeServices = new PaymentTypeServices();

        private void Iade_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            dtpStartDate.Value = new DateTime(
             dtpStartDate.Value.Year,
             dtpStartDate.Value.Month,
             dtpStartDate.Value.Day, 0, 0, 0);
            dtpEndDate.Value = new DateTime(
             dtpEndDate.Value.Year,
             dtpEndDate.Value.Month,
             dtpEndDate.Value.Day, 23, 59, 59);
        }

        private void SiparisGoruntule()
        {

            var sorgu = (from p in purchaseOrderServices.GetAll()
                         join c in employeeServices.GetAll() on p.EmployeeId equals c.EmployeeId
                         join j in purchaseOrderStatusServices.GetAll() on p.PurchaseOrderStatusId equals j.PurchaseOrderStatusId
                         join q in paymentTypeServices.GetAll() on p.PaymentTypeId equals q.PaymentTypeId
                         select new {
                             p.PurchaseOrderId,
                             c.NameSurname,
                             j.Name,
                             p.TotalPrice,
                             p.CreateDate,
                            PaymentName =  q.Name,
                            p.IsApporeved,
                            p.PurchaseOrderStatusId

                         }).Where(p => p.CreateDate > dtpStartDate.Value && p.CreateDate < dtpEndDate.Value && p.IsApporeved == true && p.PurchaseOrderStatusId == 1).ToList();
            if (sorgu != null)
            {
                dataGridView1.DataSource = sorgu;
            }
        }



        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            
            SiparisGoruntule();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var button = (DataGridViewButtonColumn)dataGridView1.Columns[e.ColumnIndex];

                if (button.Name == "SiparisDüzenle")
                {
                    int orderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PurchaseOrderId"].Value);
                    decimal totalprice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["TotalPrice"].Value);

                    OrderEdit(orderID, totalprice);
                }
          
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int orderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PurchaseOrderId"].Value);
            decimal totalprice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["TotalPrice"].Value);
            if (e.RowIndex >= 0)
            {
                OrderEdit(orderID, totalprice);
                
            }
        }

        private void OrderEdit(int orderID , decimal totalprice)
        {
            IadeEdit iadeEdit = new IadeEdit(orderID,totalprice);
            iadeEdit.ShowDialog();
            SiparisGoruntule();
          
        }
    }
}
