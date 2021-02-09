namespace BarkotTakipSistemi.CASE_OPERATİON
{
    partial class Case
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSumOrder = new System.Windows.Forms.Label();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.lblDateOrderCount = new System.Windows.Forms.Label();
            this.lblDateSumPrice = new System.Windows.Forms.Label();
            this.cmbSearchShow = new System.Windows.Forms.ComboBox();
            this.lblDateBetween = new System.Windows.Forms.Label();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PurchaseOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSumOrder);
            this.panel1.Controls.Add(this.lblSumPrice);
            this.panel1.Controls.Add(this.lblDateOrderCount);
            this.panel1.Controls.Add(this.lblDateSumPrice);
            this.panel1.Controls.Add(this.cmbSearchShow);
            this.panel1.Controls.Add(this.lblDateBetween);
            this.panel1.Controls.Add(this.btnDateSearch);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 650);
            this.panel1.TabIndex = 0;
            // 
            // lblSumOrder
            // 
            this.lblSumOrder.AutoSize = true;
            this.lblSumOrder.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSumOrder.ForeColor = System.Drawing.Color.Gold;
            this.lblSumOrder.Location = new System.Drawing.Point(598, 585);
            this.lblSumOrder.Name = "lblSumOrder";
            this.lblSumOrder.Size = new System.Drawing.Size(87, 30);
            this.lblSumOrder.TabIndex = 24;
            this.lblSumOrder.Text = "0 Adet";
            this.lblSumOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSumPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblSumPrice.Location = new System.Drawing.Point(67, 585);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(63, 30);
            this.lblSumPrice.TabIndex = 23;
            this.lblSumPrice.Text = "0 TL";
            this.lblSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateOrderCount
            // 
            this.lblDateOrderCount.AutoSize = true;
            this.lblDateOrderCount.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDateOrderCount.ForeColor = System.Drawing.Color.Gold;
            this.lblDateOrderCount.Location = new System.Drawing.Point(507, 527);
            this.lblDateOrderCount.Name = "lblDateOrderCount";
            this.lblDateOrderCount.Size = new System.Drawing.Size(437, 30);
            this.lblDateOrderCount.TabIndex = 22;
            this.lblDateOrderCount.Text = "Tarih Aralığında Yapılan Satış Miktarı";
            this.lblDateOrderCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDateSumPrice
            // 
            this.lblDateSumPrice.AutoSize = true;
            this.lblDateSumPrice.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDateSumPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblDateSumPrice.Location = new System.Drawing.Point(23, 527);
            this.lblDateSumPrice.Name = "lblDateSumPrice";
            this.lblDateSumPrice.Size = new System.Drawing.Size(470, 30);
            this.lblDateSumPrice.TabIndex = 21;
            this.lblDateSumPrice.Text = "Tarih Aralığındaki Sipariş Fiyatı Toplamı";
            this.lblDateSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSearchShow
            // 
            this.cmbSearchShow.FormattingEnabled = true;
            this.cmbSearchShow.Items.AddRange(new object[] {
            "Aktif Satışlar",
            "İade Edilen Satışlar"});
            this.cmbSearchShow.Location = new System.Drawing.Point(674, 80);
            this.cmbSearchShow.Name = "cmbSearchShow";
            this.cmbSearchShow.Size = new System.Drawing.Size(189, 21);
            this.cmbSearchShow.TabIndex = 20;
            // 
            // lblDateBetween
            // 
            this.lblDateBetween.AutoSize = true;
            this.lblDateBetween.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDateBetween.ForeColor = System.Drawing.Color.Gold;
            this.lblDateBetween.Location = new System.Drawing.Point(51, 22);
            this.lblDateBetween.Name = "lblDateBetween";
            this.lblDateBetween.Size = new System.Drawing.Size(486, 30);
            this.lblDateBetween.TabIndex = 19;
            this.lblDateBetween.Text = "Tarih Aralığına Göre Siparişleri Görüntüle";
            this.lblDateBetween.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnDateSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDateSearch.Location = new System.Drawing.Point(486, 77);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(87, 25);
            this.btnDateSearch.TabIndex = 18;
            this.btnDateSearch.Text = "Ara";
            this.btnDateSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDateSearch.UseVisualStyleBackColor = true;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Location = new System.Drawing.Point(271, 79);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 16;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(56, 79);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseOrderId,
            this.CustomerId,
            this.EmployeeName,
            this.PaymentTypeId,
            this.TotalPrice,
            this.CreateDate});
            this.dataGridView1.Location = new System.Drawing.Point(0, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(977, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // PurchaseOrderId
            // 
            this.PurchaseOrderId.DataPropertyName = "PurchaseOrderId";
            this.PurchaseOrderId.HeaderText = "Sipariş Id";
            this.PurchaseOrderId.Name = "PurchaseOrderId";
            this.PurchaseOrderId.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "Müşteri Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeId";
            this.EmployeeName.HeaderText = "Siparişi Yapan Çalışan Id";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // PaymentTypeId
            // 
            this.PaymentTypeId.DataPropertyName = "PaymentTypeId";
            this.PaymentTypeId.HeaderText = "Ödeme Tipi";
            this.PaymentTypeId.Name = "PaymentTypeId";
            this.PaymentTypeId.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Toplam Fiyat";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // CreateDate
            // 
            this.CreateDate.DataPropertyName = "CreateDate";
            this.CreateDate.HeaderText = "Satış Tarihi";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            // 
            // Case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Case";
            this.Text = "Gelir";
            this.Load += new System.EventHandler(this.Case_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSumOrder;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.Label lblDateOrderCount;
        private System.Windows.Forms.Label lblDateSumPrice;
        private System.Windows.Forms.ComboBox cmbSearchShow;
        private System.Windows.Forms.Label lblDateBetween;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }
}