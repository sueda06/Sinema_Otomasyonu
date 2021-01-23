namespace Sinema_Otomasyonu
{
    partial class Frm_Filmler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Filmler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtSure = new DevExpress.XtraEditors.TextEdit();
            this.txtTur = new DevExpress.XtraEditors.TextEdit();
            this.txtAD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.rtxtBilgi = new System.Windows.Forms.RichTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.rtxtOyuncular = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gridControl1.EmbeddedNavigator.Appearance.BackColor2 = System.Drawing.Color.Navy;
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(537, 480);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gridView1.Appearance.EvenRow.BackColor2 = System.Drawing.Color.DarkBlue;
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Navy;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 7;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(607, 21);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(113, 24);
            this.txtID.TabIndex = 1;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(607, 105);
            this.txtSure.Name = "txtSure";
            this.txtSure.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSure.Properties.Appearance.Options.UseFont = true;
            this.txtSure.Size = new System.Drawing.Size(113, 24);
            this.txtSure.TabIndex = 2;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(607, 77);
            this.txtTur.Name = "txtTur";
            this.txtTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtTur.Properties.Appearance.Options.UseFont = true;
            this.txtTur.Size = new System.Drawing.Size(113, 24);
            this.txtTur.TabIndex = 3;
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(607, 49);
            this.txtAD.Name = "txtAD";
            this.txtAD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAD.Properties.Appearance.Options.UseFont = true;
            this.txtAD.Size = new System.Drawing.Size(113, 24);
            this.txtAD.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(582, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(19, 17);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(564, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 17);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "BİLGİ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(562, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 17);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "SÜRE:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(570, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "TÜR:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(578, 54);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 17);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "AD:";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnEkle.Appearance.Options.UseBackColor = true;
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.BtnEkle.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnEkle.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.BtnEkle.AppearanceHovered.Options.UseBackColor = true;
            this.BtnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(576, 325);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(144, 29);
            this.BtnEkle.TabIndex = 11;
            this.BtnEkle.Text = "Film Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.BtnSil.AppearanceDisabled.Options.UseBackColor = true;
            this.BtnSil.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.BtnSil.AppearanceHovered.Options.UseBackColor = true;
            this.BtnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(576, 360);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(144, 29);
            this.BtnSil.TabIndex = 12;
            this.BtnSil.Text = "Film Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.BtnGuncelle.AppearanceHovered.Options.UseBackColor = true;
            this.BtnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(576, 395);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(144, 29);
            this.BtnGuncelle.TabIndex = 13;
            this.BtnGuncelle.Text = "Film Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.Blue;
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnTemizle.AppearanceHovered.Options.UseBackColor = true;
            this.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(576, 430);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(144, 29);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // rtxtBilgi
            // 
            this.rtxtBilgi.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rtxtBilgi.Location = new System.Drawing.Point(607, 135);
            this.rtxtBilgi.Name = "rtxtBilgi";
            this.rtxtBilgi.Size = new System.Drawing.Size(113, 89);
            this.rtxtBilgi.TabIndex = 15;
            this.rtxtBilgi.Text = "";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(542, 230);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 17);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "OYUNCULAR:";
            // 
            // rtxtOyuncular
            // 
            this.rtxtOyuncular.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rtxtOyuncular.Location = new System.Drawing.Point(607, 253);
            this.rtxtOyuncular.Name = "rtxtOyuncular";
            this.rtxtOyuncular.Size = new System.Drawing.Size(113, 65);
            this.rtxtOyuncular.TabIndex = 17;
            this.rtxtOyuncular.Text = "";
            // 
            // Frm_Filmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.rtxtOyuncular);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.rtxtBilgi);
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
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Filmler";
            this.Text = "Filmler";
            this.Load += new System.EventHandler(this.Frm_Filmler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtSure;
        private DevExpress.XtraEditors.TextEdit txtTur;
        private DevExpress.XtraEditors.TextEdit txtAD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private System.Windows.Forms.RichTextBox rtxtBilgi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.RichTextBox rtxtOyuncular;
    }
}