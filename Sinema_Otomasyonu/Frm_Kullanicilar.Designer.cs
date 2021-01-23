namespace Sinema_Otomasyonu
{
    partial class Frm_Kullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Kullanicilar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtPozisyon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKulAdı = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPozisyon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKulAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(551, 482);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.PaleTurquoise;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnTemizle.AppearanceHovered.Options.UseBackColor = true;
            this.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(585, 366);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(138, 29);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.BtnGuncelle.AppearanceHovered.Options.UseBackColor = true;
            this.BtnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(585, 331);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(138, 29);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "Kullanıcı Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.BtnSil.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnSil.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.BtnSil.AppearanceHovered.Options.UseBackColor = true;
            this.BtnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(585, 296);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(138, 29);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "Kullanıcı Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnEkle.Appearance.Options.UseBackColor = true;
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.BtnEkle.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnEkle.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.BtnEkle.AppearanceHovered.Options.UseBackColor = true;
            this.BtnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(585, 261);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(138, 29);
            this.BtnEkle.TabIndex = 15;
            this.BtnEkle.Text = "Kullanıcı Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(557, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 17);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Pozisyon:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(597, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 17);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(616, 41);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(107, 24);
            this.txtID.TabIndex = 21;
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.Location = new System.Drawing.Point(616, 99);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtPozisyon.Properties.Appearance.Options.UseFont = true;
            this.txtPozisyon.Size = new System.Drawing.Size(107, 24);
            this.txtPozisyon.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(557, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 17);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Kullanıcı Adı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(585, 182);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 17);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Şifre:";
            // 
            // txtKulAdı
            // 
            this.txtKulAdı.Location = new System.Drawing.Point(616, 152);
            this.txtKulAdı.Name = "txtKulAdı";
            this.txtKulAdı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtKulAdı.Properties.Appearance.Options.UseFont = true;
            this.txtKulAdı.Size = new System.Drawing.Size(107, 24);
            this.txtKulAdı.TabIndex = 25;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(616, 208);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Size = new System.Drawing.Size(107, 24);
            this.txtSifre.TabIndex = 26;
            // 
            // Frm_Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKulAdı);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPozisyon);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Kullanicilar";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Frm_Kullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPozisyon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKulAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtPozisyon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKulAdı;
        private DevExpress.XtraEditors.TextEdit txtSifre;
    }
}