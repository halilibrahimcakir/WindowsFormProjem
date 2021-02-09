
namespace BarkotTakipSistemi.PRODUCT_OPERATION
{
    partial class NewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProduct));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cmbProductCategories = new System.Windows.Forms.ComboBox();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.lblProductCategories = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductSalesPrice = new System.Windows.Forms.Label();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.lblProductExpireDate = new System.Windows.Forms.Label();
            this.txtProductSalesPrice = new System.Windows.Forms.TextBox();
            this.lblProductInPrice = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.txtProductInPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlMain.Controls.Add(this.cmbProductCategories);
            this.pnlMain.Controls.Add(this.dtpExpireDate);
            this.pnlMain.Controls.Add(this.lblProductCategories);
            this.pnlMain.Controls.Add(this.lblProductName);
            this.pnlMain.Controls.Add(this.txtProductName);
            this.pnlMain.Controls.Add(this.lblProductSalesPrice);
            this.pnlMain.Controls.Add(this.lblProductStock);
            this.pnlMain.Controls.Add(this.lblProductExpireDate);
            this.pnlMain.Controls.Add(this.txtProductSalesPrice);
            this.pnlMain.Controls.Add(this.lblProductInPrice);
            this.pnlMain.Controls.Add(this.txtProductStock);
            this.pnlMain.Controls.Add(this.txtProductInPrice);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(558, 504);
            this.pnlMain.TabIndex = 1;
            // 
            // cmbProductCategories
            // 
            this.cmbProductCategories.FormattingEnabled = true;
            this.cmbProductCategories.Location = new System.Drawing.Point(295, 114);
            this.cmbProductCategories.Name = "cmbProductCategories";
            this.cmbProductCategories.Size = new System.Drawing.Size(185, 21);
            this.cmbProductCategories.TabIndex = 47;
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpireDate.Location = new System.Drawing.Point(295, 374);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(185, 20);
            this.dtpExpireDate.TabIndex = 46;
            // 
            // lblProductCategories
            // 
            this.lblProductCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductCategories.AutoSize = true;
            this.lblProductCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductCategories.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCategories.ForeColor = System.Drawing.Color.Gold;
            this.lblProductCategories.Location = new System.Drawing.Point(63, 109);
            this.lblProductCategories.Name = "lblProductCategories";
            this.lblProductCategories.Size = new System.Drawing.Size(194, 30);
            this.lblProductCategories.TabIndex = 44;
            this.lblProductCategories.Text = "Ürün Categorisi";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductName.AutoSize = true;
            this.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductName.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.ForeColor = System.Drawing.Color.Gold;
            this.lblProductName.Location = new System.Drawing.Point(63, 31);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(113, 30);
            this.lblProductName.TabIndex = 42;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(295, 36);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 20);
            this.txtProductName.TabIndex = 41;
            // 
            // lblProductSalesPrice
            // 
            this.lblProductSalesPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductSalesPrice.AutoSize = true;
            this.lblProductSalesPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductSalesPrice.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductSalesPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblProductSalesPrice.Location = new System.Drawing.Point(63, 304);
            this.lblProductSalesPrice.Name = "lblProductSalesPrice";
            this.lblProductSalesPrice.Size = new System.Drawing.Size(142, 30);
            this.lblProductSalesPrice.TabIndex = 40;
            this.lblProductSalesPrice.Text = "Satış Fiyatı";
            // 
            // lblProductStock
            // 
            this.lblProductStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductStock.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductStock.ForeColor = System.Drawing.Color.Gold;
            this.lblProductStock.Location = new System.Drawing.Point(63, 171);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(142, 30);
            this.lblProductStock.TabIndex = 40;
            this.lblProductStock.Text = "Ürün Stock";
            // 
            // lblProductExpireDate
            // 
            this.lblProductExpireDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductExpireDate.AutoSize = true;
            this.lblProductExpireDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductExpireDate.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductExpireDate.ForeColor = System.Drawing.Color.Gold;
            this.lblProductExpireDate.Location = new System.Drawing.Point(63, 369);
            this.lblProductExpireDate.Name = "lblProductExpireDate";
            this.lblProductExpireDate.Size = new System.Drawing.Size(197, 30);
            this.lblProductExpireDate.TabIndex = 38;
            this.lblProductExpireDate.Text = "Geçerlilik Tarihi";
            // 
            // txtProductSalesPrice
            // 
            this.txtProductSalesPrice.Location = new System.Drawing.Point(295, 309);
            this.txtProductSalesPrice.Name = "txtProductSalesPrice";
            this.txtProductSalesPrice.Size = new System.Drawing.Size(185, 20);
            this.txtProductSalesPrice.TabIndex = 37;
            // 
            // lblProductInPrice
            // 
            this.lblProductInPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProductInPrice.AutoSize = true;
            this.lblProductInPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductInPrice.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductInPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblProductInPrice.Location = new System.Drawing.Point(63, 242);
            this.lblProductInPrice.Name = "lblProductInPrice";
            this.lblProductInPrice.Size = new System.Drawing.Size(143, 30);
            this.lblProductInPrice.TabIndex = 38;
            this.lblProductInPrice.Text = "Geliş Fiyatı";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(295, 176);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(185, 20);
            this.txtProductStock.TabIndex = 37;
            // 
            // txtProductInPrice
            // 
            this.txtProductInPrice.Location = new System.Drawing.Point(295, 247);
            this.txtProductInPrice.Name = "txtProductInPrice";
            this.txtProductInPrice.Size = new System.Drawing.Size(185, 20);
            this.txtProductInPrice.TabIndex = 36;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Sitka Small", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(214, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 50);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 504);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewProduct";
            this.Load += new System.EventHandler(this.NewProduct_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox cmbProductCategories;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.Label lblProductCategories;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductSalesPrice;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.Label lblProductExpireDate;
        private System.Windows.Forms.TextBox txtProductSalesPrice;
        private System.Windows.Forms.Label lblProductInPrice;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.TextBox txtProductInPrice;
        private System.Windows.Forms.Button btnSave;
    }
}