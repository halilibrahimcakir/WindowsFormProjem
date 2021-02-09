namespace BarkotTakipSistemi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cmbPwShow = new MetroFramework.Controls.MetroCheckBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPwShow
            // 
            this.cmbPwShow.Location = new System.Drawing.Point(424, 226);
            this.cmbPwShow.Name = "cmbPwShow";
            this.cmbPwShow.Size = new System.Drawing.Size(114, 15);
            this.cmbPwShow.TabIndex = 0;
            this.cmbPwShow.Text = "Şifre Göster";
            this.cmbPwShow.UseVisualStyleBackColor = true;
            this.cmbPwShow.CheckedChanged += new System.EventHandler(this.chboxShowPw_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(435, 273);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblId
            // 
            this.lblId.AllowDrop = true;
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(274, 116);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(124, 32);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Kullanıcı Adı ";
            this.lblId.UseCompatibleTextRendering = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AllowDrop = true;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Location = new System.Drawing.Point(295, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 26);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Şifre";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(424, 168);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(135, 20);
            this.txtPw.TabIndex = 7;
            this.txtPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(424, 122);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 20);
            this.txtId.TabIndex = 7;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BarkotTakipSistemi.Properties.Resources.login;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(65, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(847, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbPwShow);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblId);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Text = "Login";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroCheckBox cmbPwShow;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace SALES_OPERATION.Properties
{
    class Resources
    {
    }
}