namespace Sinema_Otomasyonu
{
    partial class Frm_Oyuncular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Oyuncular));
            this.rtxtOynFilmler = new System.Windows.Forms.RichTextBox();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAD = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtYas = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtOynFilmler
            // 
            this.rtxtOynFilmler.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rtxtOynFilmler.Location = new System.Drawing.Point(620, 204);
            this.rtxtOynFilmler.Name = "rtxtOynFilmler";
            this.rtxtOynFilmler.Size = new System.Drawing.Size(110, 65);
            this.rtxtOynFilmler.TabIndex = 30;
            this.rtxtOynFilmler.Text = "";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(580, 404);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(141, 29);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(580, 369);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(141, 29);
            this.BtnGuncelle.TabIndex = 28;
            this.BtnGuncelle.Text = "Oyuncu  Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(580, 334);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(141, 29);
            this.BtnSil.TabIndex = 27;
            this.BtnSil.Text = "Oyuncu  Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnEkle.Appearance.Options.UseBackColor = true;
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(580, 299);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(141, 29);
            this.BtnEkle.TabIndex = 26;
            this.BtnEkle.Text = "Oyuncu Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click_1);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(594, 99);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 17);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "AD:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(565, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 17);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "SOYAD:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(588, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 17);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "YAS:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(565, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 17);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "OYNADIĞI FİLMLER:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(598, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 17);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "ID:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(620, 94);
            this.txtAD.Name = "txtAD";
            this.txtAD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAD.Properties.Appearance.Options.UseFont = true;
            this.txtAD.Size = new System.Drawing.Size(110, 24);
            this.txtAD.TabIndex = 20;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(620, 122);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(110, 24);
            this.txtSoyad.TabIndex = 19;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(620, 150);
            this.txtYas.Name = "txtYas";
            this.txtYas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtYas.Properties.Appearance.Options.UseFont = true;
            this.txtYas.Size = new System.Drawing.Size(110, 24);
            this.txtYas.TabIndex = 18;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(620, 66);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(110, 24);
            this.txtID.TabIndex = 17;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(554, 480);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Gold;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // Frm_Oyuncular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.rtxtOynFilmler);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Oyuncular";
            this.Text = "Oyuncular";
            this.Load += new System.EventHandler(this.Frm_Oyuncular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtOynFilmler;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAD;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtYas;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}