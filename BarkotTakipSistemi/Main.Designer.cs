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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlAdminSubMenu = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnAdminActions = new System.Windows.Forms.Button();
            this.pnlStockSubMenu = new System.Windows.Forms.Panel();
            this.btnProductManegament = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.pnlCaseSubMenu = new System.Windows.Forms.Panel();
            this.btnVeresiye = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnCase = new System.Windows.Forms.Button();
            this.pnlSalesSubMenu = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnFastSell = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picboxFormİcon = new System.Windows.Forms.PictureBox();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.picboxMain = new System.Windows.Forms.PictureBox();
            this.pnlMainDescription = new System.Windows.Forms.Panel();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPageHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlAdminSubMenu.SuspendLayout();
            this.pnlStockSubMenu.SuspendLayout();
            this.pnlCaseSubMenu.SuspendLayout();
            this.pnlSalesSubMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFormİcon)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMain)).BeginInit();
            this.pnlMainDescription.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(250, 711);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlAdminSubMenu
            // 
            this.pnlAdminSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlAdminSubMenu.Controls.Add(this.btnAdminPanel);
            this.pnlAdminSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminSubMenu.Location = new System.Drawing.Point(0, 483);
            this.pnlAdminSubMenu.Name = "pnlAdminSubMenu";
            this.pnlAdminSubMenu.Size = new System.Drawing.Size(250, 40);
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
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnAdminActions
            // 
            this.btnAdminActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminActions.FlatAppearance.BorderSize = 0;
            this.btnAdminActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAdminActions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdminActions.Location = new System.Drawing.Point(0, 438);
            this.btnAdminActions.Name = "btnAdminActions";
            this.btnAdminActions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdminActions.Size = new System.Drawing.Size(250, 45);
            this.btnAdminActions.TabIndex = 7;
            this.btnAdminActions.Text = "Yönetici İşlemleri";
            this.btnAdminActions.UseVisualStyleBackColor = true;
            this.btnAdminActions.Click += new System.EventHandler(this.btnAdminActions_Click);
            // 
            // pnlStockSubMenu
            // 
            this.pnlStockSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlStockSubMenu.Controls.Add(this.btnProductManegament);
            this.pnlStockSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStockSubMenu.Location = new System.Drawing.Point(0, 398);
            this.pnlStockSubMenu.Name = "pnlStockSubMenu";
            this.pnlStockSubMenu.Size = new System.Drawing.Size(250, 40);
            this.pnlStockSubMenu.TabIndex = 6;
            // 
            // btnProductManegament
            // 
            this.btnProductManegament.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductManegament.FlatAppearance.BorderSize = 0;
            this.btnProductManegament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManegament.ForeColor = System.Drawing.Color.LightGray;
            this.btnProductManegament.Location = new System.Drawing.Point(0, 0);
            this.btnProductManegament.Name = "btnProductManegament";
            this.btnProductManegament.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProductManegament.Size = new System.Drawing.Size(250, 40);
            this.btnProductManegament.TabIndex = 1;
            this.btnProductManegament.Text = "Ürün Yönetimi";
            this.btnProductManegament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductManegament.UseVisualStyleBackColor = true;
            this.btnProductManegament.Click += new System.EventHandler(this.btnProductManegament_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnStock.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStock.Location = new System.Drawing.Point(0, 353);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(250, 45);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Ürün Yönetimi";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // pnlCaseSubMenu
            // 
            this.pnlCaseSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlCaseSubMenu.Controls.Add(this.btnVeresiye);
            this.pnlCaseSubMenu.Controls.Add(this.btnFinance);
            this.pnlCaseSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaseSubMenu.Location = new System.Drawing.Point(0, 270);
            this.pnlCaseSubMenu.Name = "pnlCaseSubMenu";
            this.pnlCaseSubMenu.Size = new System.Drawing.Size(250, 83);
            this.pnlCaseSubMenu.TabIndex = 4;
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
            this.btnCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCase.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCase.Location = new System.Drawing.Point(0, 225);
            this.btnCase.Name = "btnCase";
            this.btnCase.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCase.Size = new System.Drawing.Size(250, 45);
            this.btnCase.TabIndex = 3;
            this.btnCase.Text = "Kasa";
            this.btnCase.UseVisualStyleBackColor = true;
            this.btnCase.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // pnlSalesSubMenu
            // 
            this.pnlSalesSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlSalesSubMenu.Controls.Add(this.btnReport);
            this.pnlSalesSubMenu.Controls.Add(this.btnFastSell);
            this.pnlSalesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalesSubMenu.Location = new System.Drawing.Point(0, 145);
            this.pnlSalesSubMenu.Name = "pnlSalesSubMenu";
            this.pnlSalesSubMenu.Size = new System.Drawing.Size(250, 80);
            this.pnlSalesSubMenu.TabIndex = 2;
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
            this.btnReport.Text = "İade";
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
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSell.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSell.Location = new System.Drawing.Point(0, 100);
            this.btnSell.Name = "btnSell";
            this.btnSell.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSell.Size = new System.Drawing.Size(250, 45);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Satış İşlemleri";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picboxFormİcon);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // picboxFormİcon
            // 
            this.picboxFormİcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxFormİcon.Image = ((System.Drawing.Image)(resources.GetObject("picboxFormİcon.Image")));
            this.picboxFormİcon.Location = new System.Drawing.Point(0, 0);
            this.picboxFormİcon.Name = "picboxFormİcon";
            this.picboxFormİcon.Size = new System.Drawing.Size(250, 100);
            this.picboxFormİcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxFormİcon.TabIndex = 0;
            this.picboxFormİcon.TabStop = false;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlChildForm.Controls.Add(this.picboxMain);
            this.pnlChildForm.Location = new System.Drawing.Point(250, 100);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(784, 611);
            this.pnlChildForm.TabIndex = 4;
            // 
            // picboxMain
            // 
            this.picboxMain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picboxMain.Image = ((System.Drawing.Image)(resources.GetObject("picboxMain.Image")));
            this.picboxMain.Location = new System.Drawing.Point(121, 130);
            this.picboxMain.Name = "picboxMain";
            this.picboxMain.Size = new System.Drawing.Size(537, 481);
            this.picboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMain.TabIndex = 0;
            this.picboxMain.TabStop = false;
            // 
            // pnlMainDescription
            // 
            this.pnlMainDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlMainDescription.Controls.Add(this.lblPageDescription);
            this.pnlMainDescription.Controls.Add(this.lblUserName);
            this.pnlMainDescription.Controls.Add(this.lbl);
            this.pnlMainDescription.Controls.Add(this.lblPageHeader);
            this.pnlMainDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainDescription.Location = new System.Drawing.Point(250, 0);
            this.pnlMainDescription.Name = "pnlMainDescription";
            this.pnlMainDescription.Size = new System.Drawing.Size(784, 100);
            this.pnlMainDescription.TabIndex = 1;
            // 
            // lblPageDescription
            // 
            this.lblPageDescription.AutoSize = true;
            this.lblPageDescription.Font = new System.Drawing.Font("Sitka Small", 10.75F);
            this.lblPageDescription.ForeColor = System.Drawing.Color.LightGray;
            this.lblPageDescription.Location = new System.Drawing.Point(45, 57);
            this.lblPageDescription.Name = "lblPageDescription";
            this.lblPageDescription.Size = new System.Drawing.Size(406, 23);
            this.lblPageDescription.TabIndex = 0;
            this.lblPageDescription.Text = "Merhaba, Barkod Takip uygulamasına hoş geldiniz..";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Sitka Small", 10.75F);
            this.lblUserName.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserName.Location = new System.Drawing.Point(616, 57);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(101, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Login Name";
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Sitka Small", 10.75F);
            this.lbl.ForeColor = System.Drawing.Color.LightGray;
            this.lbl.Location = new System.Drawing.Point(516, 57);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(94, 23);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Kullanıcı : ";
            // 
            // lblPageHeader
            // 
            this.lblPageHeader.AutoSize = true;
            this.lblPageHeader.Font = new System.Drawing.Font("Sitka Small", 15.75F);
            this.lblPageHeader.ForeColor = System.Drawing.Color.LightGray;
            this.lblPageHeader.Location = new System.Drawing.Point(43, 19);
            this.lblPageHeader.Name = "lblPageHeader";
            this.lblPageHeader.Size = new System.Drawing.Size(118, 31);
            this.lblPageHeader.TabIndex = 0;
            this.lblPageHeader.Text = "Ana Sayfa";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 711);
            this.Controls.Add(this.pnlMainDescription);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1050, 750);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Otomasyon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlAdminSubMenu.ResumeLayout(false);
            this.pnlStockSubMenu.ResumeLayout(false);
            this.pnlCaseSubMenu.ResumeLayout(false);
            this.pnlSalesSubMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxFormİcon)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxMain)).EndInit();
            this.pnlMainDescription.ResumeLayout(false);
            this.pnlMainDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCaseSubMenu;
        private System.Windows.Forms.Button btnVeresiye;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnCase;
        private System.Windows.Forms.Panel pnlSalesSubMenu;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnFastSell;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlStockSubMenu;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProductManegament;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.PictureBox picboxFormİcon;
        private System.Windows.Forms.PictureBox picboxMain;
        private System.Windows.Forms.Panel pnlAdminSubMenu;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnAdminActions;
        private System.Windows.Forms.Panel pnlMainDescription;
        private System.Windows.Forms.Label lblPageHeader;
        private System.Windows.Forms.Label lblPageDescription;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lbl;
    }
}

