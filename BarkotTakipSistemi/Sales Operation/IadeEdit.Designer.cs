
namespace BarkotTakipSistemi.SALES_OPERATION
{
    partial class IadeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IadeEdit));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnİade = new System.Windows.Forms.Button();
            this.btnAdetDusur = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PurchaseOrderDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantitySumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGivenMoneytext = new System.Windows.Forms.Label();
            this.lblOrderTotalPricetext = new System.Windows.Forms.Label();
            this.lblGivenMoney = new System.Windows.Forms.Label();
            this.lblOrderTotalPrice = new System.Windows.Forms.Label();
            this.lblOrderIDtext = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnİade);
            this.pnlMain.Controls.Add(this.btnAdetDusur);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.dataGridView1);
            this.pnlMain.Controls.Add(this.lblGivenMoneytext);
            this.pnlMain.Controls.Add(this.lblOrderTotalPricetext);
            this.pnlMain.Controls.Add(this.lblGivenMoney);
            this.pnlMain.Controls.Add(this.lblOrderTotalPrice);
            this.pnlMain.Controls.Add(this.lblOrderIDtext);
            this.pnlMain.Controls.Add(this.lblOrderID);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(562, 529);
            this.pnlMain.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(428, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 50);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Ürünü Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnİade
            // 
            this.btnİade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnİade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnİade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİade.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnİade.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnİade.Location = new System.Drawing.Point(291, 433);
            this.btnİade.Name = "btnİade";
            this.btnİade.Size = new System.Drawing.Size(113, 50);
            this.btnİade.TabIndex = 19;
            this.btnİade.Text = "Tüm siparişi iade et";
            this.btnİade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // btnAdetDusur
            // 
            this.btnAdetDusur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdetDusur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdetDusur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdetDusur.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnAdetDusur.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdetDusur.Location = new System.Drawing.Point(17, 433);
            this.btnAdetDusur.Name = "btnAdetDusur";
            this.btnAdetDusur.Size = new System.Drawing.Size(113, 50);
            this.btnAdetDusur.TabIndex = 18;
            this.btnAdetDusur.Text = "Seçili Ürünün Adetini Düşür";
            this.btnAdetDusur.Click += new System.EventHandler(this.btnAdetDusur_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(154, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 50);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Seçili Ürünü Siparişten Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseOrderDetailId,
            this.ProductId,
            this.ProductName,
            this.Quantity,
            this.QuantitySumPrice});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 271);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // PurchaseOrderDetailId
            // 
            this.PurchaseOrderDetailId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PurchaseOrderDetailId.DataPropertyName = "PurchaseOrderDetailId";
            this.PurchaseOrderDetailId.HeaderText = "Sipariş Detay Id";
            this.PurchaseOrderDetailId.Name = "PurchaseOrderDetailId";
            this.PurchaseOrderDetailId.ReadOnly = true;
            this.PurchaseOrderDetailId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PurchaseOrderDetailId.Width = 89;
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Ürün Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ProductId.Width = 88;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Ürün Adı";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ProductName.Width = 89;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Ürün Adeti";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Quantity.Width = 88;
            // 
            // QuantitySumPrice
            // 
            this.QuantitySumPrice.DataPropertyName = "QuantitySumPrice";
            this.QuantitySumPrice.HeaderText = "Ürün Fiyatı";
            this.QuantitySumPrice.Name = "QuantitySumPrice";
            this.QuantitySumPrice.ReadOnly = true;
            this.QuantitySumPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // lblGivenMoneytext
            // 
            this.lblGivenMoneytext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGivenMoneytext.AutoSize = true;
            this.lblGivenMoneytext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGivenMoneytext.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGivenMoneytext.ForeColor = System.Drawing.Color.Gold;
            this.lblGivenMoneytext.Location = new System.Drawing.Point(297, 99);
            this.lblGivenMoneytext.Name = "lblGivenMoneytext";
            this.lblGivenMoneytext.Size = new System.Drawing.Size(181, 30);
            this.lblGivenMoneytext.TabIndex = 12;
            this.lblGivenMoneytext.Text = "lblGivenMoney";
            // 
            // lblOrderTotalPricetext
            // 
            this.lblOrderTotalPricetext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrderTotalPricetext.AutoSize = true;
            this.lblOrderTotalPricetext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderTotalPricetext.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderTotalPricetext.ForeColor = System.Drawing.Color.Gold;
            this.lblOrderTotalPricetext.Location = new System.Drawing.Point(234, 55);
            this.lblOrderTotalPricetext.Name = "lblOrderTotalPricetext";
            this.lblOrderTotalPricetext.Size = new System.Drawing.Size(165, 30);
            this.lblOrderTotalPricetext.TabIndex = 12;
            this.lblOrderTotalPricetext.Text = "lblOrderPrice";
            // 
            // lblGivenMoney
            // 
            this.lblGivenMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGivenMoney.AutoSize = true;
            this.lblGivenMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGivenMoney.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGivenMoney.ForeColor = System.Drawing.Color.Gold;
            this.lblGivenMoney.Location = new System.Drawing.Point(44, 99);
            this.lblGivenMoney.Name = "lblGivenMoney";
            this.lblGivenMoney.Size = new System.Drawing.Size(247, 30);
            this.lblGivenMoney.TabIndex = 11;
            this.lblGivenMoney.Text = "İade Edilicek Ücret :";
            // 
            // lblOrderTotalPrice
            // 
            this.lblOrderTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrderTotalPrice.AutoSize = true;
            this.lblOrderTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderTotalPrice.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderTotalPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblOrderTotalPrice.Location = new System.Drawing.Point(44, 55);
            this.lblOrderTotalPrice.Name = "lblOrderTotalPrice";
            this.lblOrderTotalPrice.Size = new System.Drawing.Size(184, 30);
            this.lblOrderTotalPrice.TabIndex = 11;
            this.lblOrderTotalPrice.Text = "Sipariş Fiyatı : ";
            // 
            // lblOrderIDtext
            // 
            this.lblOrderIDtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrderIDtext.AutoSize = true;
            this.lblOrderIDtext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderIDtext.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderIDtext.ForeColor = System.Drawing.Color.Gold;
            this.lblOrderIDtext.Location = new System.Drawing.Point(273, 9);
            this.lblOrderIDtext.Name = "lblOrderIDtext";
            this.lblOrderIDtext.Size = new System.Drawing.Size(128, 30);
            this.lblOrderIDtext.TabIndex = 10;
            this.lblOrderIDtext.Text = "lblOrderId";
            // 
            // lblOrderID
            // 
            this.lblOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderID.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderID.ForeColor = System.Drawing.Color.Gold;
            this.lblOrderID.Location = new System.Drawing.Point(44, 9);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(223, 30);
            this.lblOrderID.TabIndex = 9;
            this.lblOrderID.Text = "Siparis Numarası :";
            // 
            // IadeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(562, 529);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IadeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İade Düzenle";
            this.Load += new System.EventHandler(this.IadeEdit_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnİade;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblOrderTotalPricetext;
        private System.Windows.Forms.Label lblOrderTotalPrice;
        private System.Windows.Forms.Label lblOrderIDtext;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGivenMoneytext;
        private System.Windows.Forms.Label lblGivenMoney;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdetDusur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantitySumPrice;
    }
}