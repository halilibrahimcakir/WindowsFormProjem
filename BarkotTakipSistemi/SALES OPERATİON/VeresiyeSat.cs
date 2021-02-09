﻿using BarkotTakip.Business.Service;
using BarkotTakip.Data.Context;
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

namespace BarkotTakipSistemi.SALES_OPERATİON
{
    public partial class VeresiyeSat : Form
    {
        public VeresiyeSat()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

        }
        ICustomerServices customerServices = new CustomerServices();

        public int Customerid
        {
            get; set;
        }

        private void VeresiyeSat_Load(object sender, EventArgs e)
        {
            
            LoadList();

        }

        private void LoadList()
        {
            dataGridView1.DataSource = customerServices.GetAll().ToList();
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value);
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= -1)
            {
                var button = (DataGridViewButtonColumn)dataGridView1.Columns[e.ColumnIndex];

                if (button.Name == "Add")
                {
                    Customerid = id;
                    CustomerTetikle(id);
                }
            }

        }



        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            var senderGrid = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(senderGrid.Rows[e.RowIndex].Cells["CustomerId"].Value);
                Customerid = id;
                CustomerTetikle(id);
            }


        }
        public void CustomerTetikle(int id)
        {

            DialogResult dialogResult = MessageBox.Show(id + "kişiye veresiye eklenecektir ! Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Sipariş Eklendi");
                Cache.Operation = true;
                Close();
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadList();
            }
            else
            {
                dataGridView1.DataSource = customerServices.GetAll().Where(p => p.NameSurname.ToString() == txtSearch.Text.ToString()).FirstOrDefault();
            }

        }


    }
}
