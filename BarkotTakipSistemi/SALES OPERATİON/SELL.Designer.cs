namespace BarkotTakipSistemi
{
    partial class SELL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblProductsPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.pnlParaUstu = new System.Windows.Forms.Panel();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.lblChangeGivenTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChangeGiven = new System.Windows.Forms.Label();
            this.btnProductFind = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlSalesButton = new System.Windows.Forms.Panel();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnVeresiye = new System.Windows.Forms.Button();
            this.btnKredi = new System.Windows.Forms.Button();
            this.btnNakit = new System.Windows.Forms.Button();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            this.pnlParaUstu.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSalesButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblProductsPrice);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.txtProducts);
            this.pnlMain.Controls.Add(this.lblBarkod);
            this.pnlMain.Controls.Add(this.pnlParaUstu);
            this.pnlMain.Controls.Add(this.btnProductFind);
            this.pnlMain.Controls.Add(this.pnlGrid);
            this.pnlMain.Controls.Add(this.pnlSalesButton);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Leelawadee", 8.25F);
            this.pnlMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(950, 673);
            this.pnlMain.TabIndex = 0;
            // 
            // lblProductsPrice
            // 
            this.lblProductsPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductsPrice.AutoSize = true;
            this.lblProductsPrice.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProductsPrice.Location = new System.Drawing.Point(663, 366);
            this.lblProductsPrice.Name = "lblProductsPrice";
            this.lblProductsPrice.Size = new System.Drawing.Size(51, 30);
            this.lblProductsPrice.TabIndex = 10;
            this.lblProductsPrice.Text = "0 TL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(540, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "TUTAR :";
            // 
            // txtProducts
            // 
            this.txtProducts.AcceptsReturn = true;
            this.txtProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProducts.Location = new System.Drawing.Point(156, 375);
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(219, 21);
            this.txtProducts.TabIndex = 11;
            this.txtProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProducts.TextChanged += new System.EventHandler(this.txtProducts_TextChanged);
            // 
            // lblBarkod
            // 
            this.lblBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBarkod.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.ForeColor = System.Drawing.Color.Gold;
            this.lblBarkod.Location = new System.Drawing.Point(23, 370);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(126, 30);
            this.lblBarkod.TabIndex = 7;
            this.lblBarkod.Text = "BARKOD :";
            // 
            // pnlParaUstu
            // 
            this.pnlParaUstu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParaUstu.Controls.Add(this.btnHesapla);
            this.pnlParaUstu.Controls.Add(this.txtReceived);
            this.pnlParaUstu.Controls.Add(this.lblChangeGivenTxt);
            this.pnlParaUstu.Controls.Add(this.label3);
            this.pnlParaUstu.Controls.Add(this.lblChangeGiven);
            this.pnlParaUstu.Location = new System.Drawing.Point(489, 433);
            this.pnlParaUstu.Name = "pnlParaUstu";
            this.pnlParaUstu.Size = new System.Drawing.Size(458, 225);
            this.pnlParaUstu.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnHesapla.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHesapla.Location = new System.Drawing.Point(147, 136);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(129, 71);
            this.btnHesapla.TabIndex = 12;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(236, 85);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(134, 21);
            this.txtReceived.TabIndex = 11;
            // 
            // lblChangeGivenTxt
            // 
            this.lblChangeGivenTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChangeGivenTxt.AutoSize = true;
            this.lblChangeGivenTxt.Font = new System.Drawing.Font("Leelawadee UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeGivenTxt.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChangeGivenTxt.Location = new System.Drawing.Point(225, 15);
            this.lblChangeGivenTxt.Name = "lblChangeGivenTxt";
            this.lblChangeGivenTxt.Size = new System.Drawing.Size(51, 30);
            this.lblChangeGivenTxt.TabIndex = 10;
            this.lblChangeGivenTxt.Text = "0 TL";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(52, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Verilen Para :";
            // 
            // lblChangeGiven
            // 
            this.lblChangeGiven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChangeGiven.AutoSize = true;
            this.lblChangeGiven.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChangeGiven.ForeColor = System.Drawing.Color.Gold;
            this.lblChangeGiven.Location = new System.Drawing.Point(52, 15);
            this.lblChangeGiven.Name = "lblChangeGiven";
            this.lblChangeGiven.Size = new System.Drawing.Size(161, 30);
            this.lblChangeGiven.TabIndex = 9;
            this.lblChangeGiven.Text = "PARA ÜSTÜ :";
            // 
            // btnProductFind
            // 
            this.btnProductFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductFind.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnProductFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductFind.Location = new System.Drawing.Point(739, 43);
            this.btnProductFind.Name = "btnProductFind";
            this.btnProductFind.Size = new System.Drawing.Size(180, 80);
            this.btnProductFind.TabIndex = 5;
            this.btnProductFind.Text = "Ürün Bul";
            this.btnProductFind.UseVisualStyleBackColor = true;
            this.btnProductFind.Click += new System.EventHandler(this.btnProductFind_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrid.AutoSize = true;
            this.pnlGrid.Controls.Add(this.dataGridView1);
            this.pnlGrid.Location = new System.Drawing.Point(12, 12);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(714, 320);
            this.pnlGrid.TabIndex = 4;
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
            this.ProductId,
            this.ProductName,
            this.CategoryName,
            this.Count,
            this.SalesPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(714, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // pnlSalesButton
            // 
            this.pnlSalesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSalesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSalesButton.Controls.Add(this.btnİptal);
            this.pnlSalesButton.Controls.Add(this.btnVeresiye);
            this.pnlSalesButton.Controls.Add(this.btnKredi);
            this.pnlSalesButton.Controls.Add(this.btnNakit);
            this.pnlSalesButton.Location = new System.Drawing.Point(12, 433);
            this.pnlSalesButton.Name = "pnlSalesButton";
            this.pnlSalesButton.Size = new System.Drawing.Size(471, 225);
            this.pnlSalesButton.TabIndex = 2;
            // 
            // btnİptal
            // 
            this.btnİptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnİptal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnİptal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnİptal.Location = new System.Drawing.Point(245, 129);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(210, 85);
            this.btnİptal.TabIndex = 1;
            this.btnİptal.Text = "F4 - İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnVeresiye
            // 
            this.btnVeresiye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVeresiye.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVeresiye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeresiye.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnVeresiye.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVeresiye.Location = new System.Drawing.Point(16, 129);
            this.btnVeresiye.Name = "btnVeresiye";
            this.btnVeresiye.Size = new System.Drawing.Size(210, 85);
            this.btnVeresiye.TabIndex = 1;
            this.btnVeresiye.Text = " F3- VERESİYE";
            this.btnVeresiye.UseVisualStyleBackColor = true;
            this.btnVeresiye.Click += new System.EventHandler(this.btnVeresiye_Click);
            // 
            // btnKredi
            // 
            this.btnKredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKredi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnKredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKredi.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnKredi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKredi.Location = new System.Drawing.Point(245, 15);
            this.btnKredi.Name = "btnKredi";
            this.btnKredi.Size = new System.Drawing.Size(210, 85);
            this.btnKredi.TabIndex = 1;
            this.btnKredi.Text = "F2 - KREDİ KARTI";
            this.btnKredi.UseVisualStyleBackColor = false;
            this.btnKredi.Click += new System.EventHandler(this.btnKredi_Click);
            // 
            // btnNakit
            // 
            this.btnNakit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNakit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNakit.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnNakit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNakit.Location = new System.Drawing.Point(16, 15);
            this.btnNakit.Name = "btnNakit";
            this.btnNakit.Size = new System.Drawing.Size(210, 85);
            this.btnNakit.TabIndex = 2;
            this.btnNakit.Text = "F1-  NAKİT";
            this.btnNakit.Click += new System.EventHandler(this.btnNakit_Click);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Ürün Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Ürün Adı";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Categori Adı";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Adet";
            this.Count.Name = "Count";
            // 
            // SalesPrice
            // 
            this.SalesPrice.DataPropertyName = "SalesPrice";
            this.SalesPrice.HeaderText = "Fiyat";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            // 
            // SELL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(950, 673);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "SELL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ YAP";
            this.Load += new System.EventHandler(this.SELL_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SELL_KeyDown);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlParaUstu.ResumeLayout(false);
            this.pnlParaUstu.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSalesButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnVeresiye;
        private System.Windows.Forms.Button btnKredi;
        private System.Windows.Forms.Button btnNakit;
        private System.Windows.Forms.Panel pnlSalesButton;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Button btnProductFind;
        private System.Windows.Forms.Label lblProductsPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.Panel pnlParaUstu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label lblChangeGivenTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChangeGiven;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
    }
}