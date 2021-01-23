namespace Sinema_Otomasyonu
{
    partial class Frm_Yorumlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Yorumlar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rtxtYorum = new System.Windows.Forms.RichTextBox();
            this.cmbFilm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnYorumuGetir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.rtxtIsim = new System.Windows.Forms.RichTextBox();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(531, 482);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Gray;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(557, 199);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "İSİM:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(537, 259);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 17);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "YORUM:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(555, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 17);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "FİLM:";
            // 
            // rtxtYorum
            // 
            this.rtxtYorum.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rtxtYorum.Location = new System.Drawing.Point(537, 280);
            this.rtxtYorum.Name = "rtxtYorum";
            this.rtxtYorum.Size = new System.Drawing.Size(196, 130);
            this.rtxtYorum.TabIndex = 8;
            this.rtxtYorum.Text = "";
            // 
            // cmbFilm
            // 
            this.cmbFilm.Location = new System.Drawing.Point(608, 111);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbFilm.Properties.Appearance.Options.UseFont = true;
            this.cmbFilm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFilm.Size = new System.Drawing.Size(125, 24);
            this.cmbFilm.TabIndex = 9;
            // 
            // btnYorumuGetir
            // 
            this.btnYorumuGetir.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnYorumuGetir.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnYorumuGetir.Appearance.Options.UseBackColor = true;
            this.btnYorumuGetir.Appearance.Options.UseFont = true;
            this.btnYorumuGetir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnYorumuGetir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYorumuGetir.ImageOptions.Image")));
            this.btnYorumuGetir.Location = new System.Drawing.Point(608, 151);
            this.btnYorumuGetir.Name = "btnYorumuGetir";
            this.btnYorumuGetir.Size = new System.Drawing.Size(125, 29);
            this.btnYorumuGetir.TabIndex = 10;
            this.btnYorumuGetir.Text = "Yorumu Getir";
            this.btnYorumuGetir.Click += new System.EventHandler(this.btnYorumuGetir_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Pink;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(537, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(210, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Yorumunu Görmek İstediğiniz ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseBackColor = true;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(590, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 17);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Filmi Seçiniz";
            // 
            // rtxtIsim
            // 
            this.rtxtIsim.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.rtxtIsim.Location = new System.Drawing.Point(608, 196);
            this.rtxtIsim.Name = "rtxtIsim";
            this.rtxtIsim.Size = new System.Drawing.Size(125, 53);
            this.rtxtIsim.TabIndex = 13;
            this.rtxtIsim.Text = "";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(608, 416);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(125, 29);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Frm_Yorumlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.rtxtIsim);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnYorumuGetir);
            this.Controls.Add(this.cmbFilm);
            this.Controls.Add(this.rtxtYorum);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Yorumlar";
            this.Text = "Yorumlar";
            this.Load += new System.EventHandler(this.Frm_Yorumlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFilm.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox rtxtYorum;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFilm;
        private DevExpress.XtraEditors.SimpleButton btnYorumuGetir;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox rtxtIsim;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}