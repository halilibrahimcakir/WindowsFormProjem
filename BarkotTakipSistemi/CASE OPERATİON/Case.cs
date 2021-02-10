using BarkotTakip.Business.Services;
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
    public partial class Case : Form
    {
        public Case()
        {
            InitializeComponent();
        }
        IPurchaseOrderServices purchaseOrderServices = new PurchaseOrderServices();
        //ICustomerServices customerServices = new CustomerServices();
        //IEmployeeServices employeeServices = new EmployeesServices();
        //IPaymentTypeServices paymentTypeServices = new PaymentTypeServices();
        private void Case_Load(object sender, EventArgs e)
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
            LoadOrder();
        }

        private void LoadOrder()
        {
            //var sorgu = (from o in purchaseOrderServices.GetAll()
            //             join c in customerServices.GetAll() on o.CustomerId equals c.CustomerId
            //             join e in employeeServices.GetAll() on o.EmployeeId equals e.EmployeeId
            //             join p in paymentTypeServices.GetAll() on o.PaymentTypeId equals p.PaymentTypeId
            //             into leftjoin
            //             from cek in leftjoin
            //             select new  {
            //                 PurchaseOrderId = o.PurchaseOrderId,
            //                 CustomerId = o.CustomerId,
            //                 Customername = c.NameSurname,
            //                 EmployeeName = e.NameSurname,
            //                 TotalPrice = o.TotalPrice,
            //                 CreateDate = o.CreateDate,
            //                 PaymentName = p.Name
            //             }).ToList();
            cmbSearchShow.SelectedIndex = 0;
            var sorgu = purchaseOrderServices.GetAll().Where(p => p.CreateDate > dtpStartDate.Value && p.CreateDate < dtpEndDate.Value).ToList();

            dataGridView1.DataSource = sorgu;
            lblSumPrice.Text = sorgu.Sum(p => p.TotalPrice.Value).ToString();
            lblSumOrder.Text = sorgu.Count().ToString();

           
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchShow.SelectedIndex == 0)
            {
                var sorgu = purchaseOrderServices.GetAll().Where(p => p.CreateDate > dtpStartDate.Value && p.CreateDate < dtpEndDate.Value && p.PurchaseOrderStatusId == 1).ToList();
                dataGridView1.DataSource = sorgu;
                lblSumPrice.Text = sorgu.Sum(p => p.TotalPrice.Value).ToString();
                lblSumOrder.Text = sorgu.Count().ToString();
            }
            else
            {
                var sorgu = purchaseOrderServices.GetAll().Where(p => p.CreateDate > dtpStartDate.Value && p.CreateDate < dtpEndDate.Value && p.PurchaseOrderStatusId == 2).ToList();
                dataGridView1.DataSource = sorgu;
                lblSumPrice.Text = sorgu.Sum(p => p.TotalPrice.Value).ToString();
                lblSumOrder.Text = sorgu.Count().ToString();
            }
        }
    }
}
