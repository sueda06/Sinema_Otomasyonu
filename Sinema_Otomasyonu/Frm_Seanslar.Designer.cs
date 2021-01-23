namespace Sinema_Otomasyonu
{
    partial class Frm_Seanslar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Seanslar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lbl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaat = new DevExpress.XtraEditors.TextEdit();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(546, 480);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(580, 328);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 29);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.Fuchsia;
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(580, 293);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(138, 29);
            this.BtnGuncelle.TabIndex = 32;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(580, 258);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(138, 29);
            this.BtnSil.TabIndex = 31;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnEkle.Appearance.Options.UseBackColor = true;
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(580, 223);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(138, 29);
            this.BtnEkle.TabIndex = 30;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lbl2
            // 
            this.lbl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl2.Appearance.Options.UseFont = true;
            this.lbl2.Location = new System.Drawing.Point(568, 151);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(37, 17);
            this.lbl2.TabIndex = 39;
            this.lbl2.Text = "SAAT:";
            // 
            // lbl3
            // 
            this.lbl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl3.Appearance.Options.UseFont = true;
            this.lbl3.Location = new System.Drawing.Point(582, 179);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(23, 17);
            this.lbl3.TabIndex = 38;
            this.lbl3.Text = "AD:";
            // 
            // lbl1
            // 
            this.lbl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl1.Appearance.Options.UseFont = true;
            this.lbl1.Location = new System.Drawing.Point(586, 124);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 17);
            this.lbl1.TabIndex = 37;
            this.lbl1.Text = "ID:";
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(611, 148);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSaat.Properties.Appearance.Options.UseFont = true;
            this.txtSaat.Size = new System.Drawing.Size(107, 24);
            this.txtSaat.TabIndex = 36;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(611, 176);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(107, 24);
            this.txtAd.TabIndex = 35;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(611, 120);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(107, 24);
            this.txtID.TabIndex = 34;
            // 
            // Frm_Seanslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Seanslar";
            this.Text = "Seanslar";
            this.Load += new System.EventHandler(this.Frm_Seanslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.LabelControl lbl2;
        private DevExpress.XtraEditors.LabelControl lbl3;
        private DevExpress.XtraEditors.LabelControl lbl1;
        private DevExpress.XtraEditors.TextEdit txtSaat;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtID;
    }
}