namespace BarkotTakipSistemi
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlAdminSubMenu = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnAdminActions = new System.Windows.Forms.Button();
            this.pnlStockSubMenu = new System.Windows.Forms.Panel();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.pnlCaseSubMenu = new System.Windows.Forms.Panel();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnVeresiye = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnCase = new System.Windows.Forms.Button();
            this.pnlSalesSubMenu = new System.Windows.Forms.Panel();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFastSell = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlAdminSubMenu.SuspendLayout();
            this.pnlStockSubMenu.SuspendLayout();
            this.pnlCaseSubMenu.SuspendLayout();
            this.pnlSalesSubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlMain.Controls.Add(this.pnlAdminSubMenu);
            this.pnlMain.Controls.Add(this.btnAdminActions);
            this.pnlMain.Controls.Add(this.pnlStockSubMenu);
            this.pnlMain.Controls.Add(this.btnStock);
            this.pnlMain.Controls.Add(this.pnlCaseSubMenu);
            this.pnlMain.Controls.Add(this.btnCase);
            this.pnlMain.Controls.Add(this.pnlSalesSubMenu);
            this.pnlMain.Controls.Add(this.btnSell);
            this.pnlMain.Controls.Add(this.pnlLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(250, 669);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlAdminSubMenu
            // 
            this.pnlAdminSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlAdminSubMenu.Controls.Add(this.btnAdminPanel);
            this.pnlAdminSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdminSubMenu.Location = new System.Drawing.Point(0, 600);
            this.pnlAdminSubMenu.Name = "pnlAdminSubMenu";
            this.pnlAdminSubMenu.Size = new System.Drawing.Size(250, 69);
            this.pnlAdminSubMenu.TabIndex = 8;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.ForeColor = System.Drawing.Color.LightGray;
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 0);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdminPanel.Size = new System.Drawing.Size(250, 40);
            this.btnAdminPanel.TabIndex = 1;
            this.btnAdminPanel.Text = "Yönetici Paneli";
            this.btnAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            // 
            // btnAdminActions
            // 
            this.btnAdminActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminActions.FlatAppearance.BorderSize = 0;
            this.btnAdminActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminActions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdminActions.Location = new System.Drawing.Point(0, 555);
            this.btnAdminActions.Name = "btnAdminActions";
            this.btnAdminActions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminActions.Size = new System.Drawing.Size(250, 45);
            this.btnAdminActions.TabIndex = 7;
            this.btnAdminActions.Text = "Yönetimsel İşlemler";
            this.btnAdminActions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminActions.UseVisualStyleBackColor = true;
            // 
            // pnlStockSubMenu
            // 
            this.pnlStockSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlStockSubMenu.Controls.Add(this.btnAddStock);
            this.pnlStockSubMenu.Controls.Add(this.btnViewStock);
            this.pnlStockSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStockSubMenu.Location = new System.Drawing.Point(0, 475);
            this.pnlStockSubMenu.Name = "pnlStockSubMenu";
            this.pnlStockSubMenu.Size = new System.Drawing.Size(250, 80);
            this.pnlStockSubMenu.TabIndex = 6;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddStock.Location = new System.Drawing.Point(0, 40);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddStock.Size = new System.Drawing.Size(250, 40);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "Stok Ekle";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewStock.FlatAppearance.BorderSize = 0;
            this.btnViewStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStock.ForeColor = System.Drawing.Color.LightGray;
            this.btnViewStock.Location = new System.Drawing.Point(0, 0);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnViewStock.Size = new System.Drawing.Size(250, 40);
            this.btnViewStock.TabIndex = 0;
            this.btnViewStock.Text = "Stok Görüntüle";
            this.btnViewStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStock.Location = new System.Drawing.Point(0, 430);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(250, 45);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Stok";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // pnlCaseSubMenu
            // 
            this.pnlCaseSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlCaseSubMenu.Controls.Add(this.btnCari);
            this.pnlCaseSubMenu.Controls.Add(this.btnVeresiye);
            this.pnlCaseSubMenu.Controls.Add(this.btnFinance);
            this.pnlCaseSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaseSubMenu.Location = new System.Drawing.Point(0, 310);
            this.pnlCaseSubMenu.Name = "pnlCaseSubMenu";
            this.pnlCaseSubMenu.Size = new System.Drawing.Size(250, 120);
            this.pnlCaseSubMenu.TabIndex = 4;
            // 
            // btnCari
            // 
            this.btnCari.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCari.FlatAppearance.BorderSize = 0;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.ForeColor = System.Drawing.Color.LightGray;
            this.btnCari.Location = new System.Drawing.Point(0, 80);
            this.btnCari.Name = "btnCari";
            this.btnCari.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCari.Size = new System.Drawing.Size(250, 40);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnVeresiye
            // 
            this.btnVeresiye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVeresiye.FlatAppearance.BorderSize = 0;
            this.btnVeresiye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeresiye.ForeColor = System.Drawing.Color.LightGray;
            this.btnVeresiye.Location = new System.Drawing.Point(0, 40);
            this.btnVeresiye.Name = "btnVeresiye";
            this.btnVeresiye.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVeresiye.Size = new System.Drawing.Size(250, 40);
            this.btnVeresiye.TabIndex = 1;
            this.btnVeresiye.Text = "Veresiye";
            this.btnVeresiye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVeresiye.UseVisualStyleBackColor = true;
            this.btnVeresiye.Click += new System.EventHandler(this.btnVeresiye_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinance.FlatAppearance.BorderSize = 0;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinance.ForeColor = System.Drawing.Color.LightGray;
            this.btnFinance.Location = new System.Drawing.Point(0, 0);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFinance.Size = new System.Drawing.Size(250, 40);
            this.btnFinance.TabIndex = 0;
            this.btnFinance.Text = "Gelir";
            this.btnFinance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnCase
            // 
            this.btnCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCase.FlatAppearance.BorderSize = 0;
            this.btnCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCase.Location = new System.Drawing.Point(0, 265);
            this.btnCase.Name = "btnCase";
            this.btnCase.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCase.Size = new System.Drawing.Size(250, 45);
            this.btnCase.TabIndex = 3;
            this.btnCase.Text = "Kasa";
            this.btnCase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCase.UseVisualStyleBackColor = true;
            this.btnCase.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // pnlSalesSubMenu
            // 
            this.pnlSalesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSalesSubMenu.Controls.Add(this.btnInvoice);
            this.pnlSalesSubMenu.Controls.Add(this.btnReport);
            this.pnlSalesSubMenu.Controls.Add(this.btnFastSell);
            this.pnlSalesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalesSubMenu.Location = new System.Drawing.Point(0, 145);
            this.pnlSalesSubMenu.Name = "pnlSalesSubMenu";
            this.pnlSalesSubMenu.Size = new System.Drawing.Size(250, 120);
            this.pnlSalesSubMenu.TabIndex = 2;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.ForeColor = System.Drawing.Color.LightGray;
            this.btnInvoice.Location = new System.Drawing.Point(0, 80);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnInvoice.Size = new System.Drawing.Size(250, 40);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "Fatura / Fiş";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.LightGray;
            this.btnReport.Location = new System.Drawing.Point(0, 40);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(250, 40);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Raporlar";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnFastSell
            // 
            this.btnFastSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFastSell.FlatAppearance.BorderSize = 0;
            this.btnFastSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastSell.ForeColor = System.Drawing.Color.LightGray;
            this.btnFastSell.Location = new System.Drawing.Point(0, 0);
            this.btnFastSell.Name = "btnFastSell";
            this.btnFastSell.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFastSell.Size = new System.Drawing.Size(250, 40);
            this.btnFastSell.TabIndex = 0;
            this.btnFastSell.Text = "Hızlı Satış";
            this.btnFastSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFastSell.UseVisualStyleBackColor = true;
            this.btnFastSell.Click += new System.EventHandler(this.btnFastSell_Click);
            // 
            // btnSell
            // 
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSell.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSell.Location = new System.Drawing.Point(0, 100);
            this.btnSell.Name = "btnSell";
            this.btnSell.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSell.Size = new System.Drawing.Size(250, 45);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Satış";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BarkotTakipSistemi.Properties.Resources.Varlık_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlChildForm.Controls.Add(this.panel1);
            this.pnlChildForm.Controls.Add(this.pictureBox2);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(250, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(770, 669);
            this.pnlChildForm.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 94);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "lblPageHeader";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::BarkotTakipSistemi.Properties.Resources.pngegg;
            this.pictureBox2.Location = new System.Drawing.Point(118, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(514, 435);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 669);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Otomasyon";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlAdminSubMenu.ResumeLayout(false);
            this.pnlStockSubMenu.ResumeLayout(false);
            this.pnlCaseSubMenu.ResumeLayout(false);
            this.pnlSalesSubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCaseSubMenu;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnVeresiye;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnCase;
        private System.Windows.Forms.Panel pnlSalesSubMenu;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnFastSell;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlStockSubMenu;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlAdminSubMenu;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnAdminActions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

