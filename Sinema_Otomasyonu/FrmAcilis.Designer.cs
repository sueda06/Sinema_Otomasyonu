namespace Sinema_Otomasyonu
{
    partial class FrmAcilis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcilis));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAdminGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Sinema_Otomasyonu.Properties.Resources.dijital_tiyatro;
            this.pictureEdit1.Location = new System.Drawing.Point(-4, -1);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(762, 662);
            this.pictureEdit1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdminGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnAdminGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAdminGiris.Appearance.Options.UseBackColor = true;
            this.btnAdminGiris.Appearance.Options.UseFont = true;
            this.btnAdminGiris.Appearance.Options.UseForeColor = true;
            this.btnAdminGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdminGiris.Location = new System.Drawing.Point(291, 468);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(175, 28);
            this.btnAdminGiris.TabIndex = 2;
            this.btnAdminGiris.Text = "Admin Girişi";
            this.btnAdminGiris.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMusteriGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnMusteriGiris.Appearance.Options.UseBackColor = true;
            this.btnMusteriGiris.Appearance.Options.UseFont = true;
            this.btnMusteriGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnMusteriGiris.Location = new System.Drawing.Point(291, 502);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.Size = new System.Drawing.Size(175, 28);
            this.btnMusteriGiris.TabIndex = 3;
            this.btnMusteriGiris.Text = "Müşteri Girişi";
            this.btnMusteriGiris.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(341, 409);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Properties.Appearance.BackColor = System.Drawing.Color.Bisque;
            this.txtKullaniciAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtKullaniciAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtKullaniciAd.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAd.Size = new System.Drawing.Size(125, 24);
            this.txtKullaniciAd.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(341, 439);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.BackColor = System.Drawing.Color.Bisque;
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSifre.Properties.Appearance.Options.UseBackColor = true;
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(125, 24);
            this.txtSifre.TabIndex = 5;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(259, 548);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.progressBarControl1.Size = new System.Drawing.Size(239, 22);
            this.progressBarControl1.TabIndex = 8;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(291, 397);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(35, 32);
            this.pictureEdit2.TabIndex = 9;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(291, 435);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(35, 32);
            this.pictureEdit3.TabIndex = 10;
            // 
            // FrmAcilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 653);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.btnMusteriGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.pictureEdit1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcilis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinema Otomasyonu";
            this.Load += new System.EventHandler(this.FrmAcilis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btnAdminGiris;
        private DevExpress.XtraEditors.SimpleButton btnMusteriGiris;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAd;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
    }
}