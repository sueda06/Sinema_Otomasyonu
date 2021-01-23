namespace Sinema_Otomasyonu
{
    partial class Frm_Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Musteriler));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lbl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbl6 = new DevExpress.XtraEditors.LabelControl();
            this.lbl7 = new DevExpress.XtraEditors.LabelControl();
            this.lbl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAD = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mtxtTc = new System.Windows.Forms.MaskedTextBox();
            this.lbl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbl5 = new DevExpress.XtraEditors.LabelControl();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbBiletAldFilm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbBiletAldSeans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBiletAldFilm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBiletAldSeans.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(575, 412);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 29);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnGuncelle.Appearance.Options.UseBackColor = true;
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(575, 377);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(138, 29);
            this.BtnGuncelle.TabIndex = 28;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSil.Appearance.Options.UseBackColor = true;
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(575, 342);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(138, 29);
            this.BtnSil.TabIndex = 27;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnEkle.Appearance.Options.UseBackColor = true;
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(575, 307);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(138, 29);
            this.BtnEkle.TabIndex = 26;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lbl2
            // 
            this.lbl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl2.Appearance.Options.UseFont = true;
            this.lbl2.Location = new System.Drawing.Point(584, 57);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(23, 17);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "AD:";
            // 
            // lbl3
            // 
            this.lbl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl3.Appearance.Options.UseFont = true;
            this.lbl3.Location = new System.Drawing.Point(559, 87);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(49, 17);
            this.lbl3.TabIndex = 24;
            this.lbl3.Text = "SOYAD:";
            // 
            // lbl6
            // 
            this.lbl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl6.Appearance.Options.UseFont = true;
            this.lbl6.Location = new System.Drawing.Point(575, 177);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(33, 17);
            this.lbl6.TabIndex = 23;
            this.lbl6.Text = "FİLM:";
            // 
            // lbl7
            // 
            this.lbl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl7.Appearance.Options.UseFont = true;
            this.lbl7.Location = new System.Drawing.Point(562, 209);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(46, 17);
            this.lbl7.TabIndex = 22;
            this.lbl7.Text = "SEANS:";
            // 
            // lbl1
            // 
            this.lbl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl1.Appearance.Options.UseFont = true;
            this.lbl1.Location = new System.Drawing.Point(587, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(19, 17);
            this.lbl1.TabIndex = 21;
            this.lbl1.Text = "ID:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(612, 54);
            this.txtAD.Name = "txtAD";
            this.txtAD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtAD.Properties.Appearance.Options.UseFont = true;
            this.txtAD.Size = new System.Drawing.Size(107, 24);
            this.txtAD.TabIndex = 20;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(612, 82);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(107, 24);
            this.txtSoyad.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(612, 26);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(107, 24);
            this.txtID.TabIndex = 17;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(546, 479);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.OliveDrab;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // mtxtTc
            // 
            this.mtxtTc.Location = new System.Drawing.Point(612, 112);
            this.mtxtTc.Mask = "00000000000";
            this.mtxtTc.Name = "mtxtTc";
            this.mtxtTc.Size = new System.Drawing.Size(107, 22);
            this.mtxtTc.TabIndex = 31;
            this.mtxtTc.ValidatingType = typeof(int);
            // 
            // lbl4
            // 
            this.lbl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl4.Appearance.Options.UseFont = true;
            this.lbl4.Location = new System.Drawing.Point(584, 114);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(22, 17);
            this.lbl4.TabIndex = 32;
            this.lbl4.Text = "TC:";
            // 
            // lbl5
            // 
            this.lbl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl5.Appearance.Options.UseFont = true;
            this.lbl5.Location = new System.Drawing.Point(578, 145);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(28, 17);
            this.lbl5.TabIndex = 34;
            this.lbl5.Text = "TEL:";
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Location = new System.Drawing.Point(612, 143);
            this.mtxtTelefon.Mask = "(999) 000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(107, 22);
            this.mtxtTelefon.TabIndex = 33;
            // 
            // cmbBiletAldFilm
            // 
            this.cmbBiletAldFilm.Location = new System.Drawing.Point(612, 175);
            this.cmbBiletAldFilm.Name = "cmbBiletAldFilm";
            this.cmbBiletAldFilm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBiletAldFilm.Size = new System.Drawing.Size(106, 22);
            this.cmbBiletAldFilm.TabIndex = 35;
            // 
            // cmbBiletAldSeans
            // 
            this.cmbBiletAldSeans.Location = new System.Drawing.Point(612, 207);
            this.cmbBiletAldSeans.Name = "cmbBiletAldSeans";
            this.cmbBiletAldSeans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBiletAldSeans.Size = new System.Drawing.Size(106, 22);
            this.cmbBiletAldSeans.TabIndex = 36;
            this.cmbBiletAldSeans.SelectedIndexChanged += new System.EventHandler(this.cmbBiletAldSeans_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(612, 245);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 21);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ÖĞRENCİ 9 TL";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(630, 272);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 21);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TAM 12 TL";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbl8
            // 
            this.lbl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl8.Appearance.Options.UseFont = true;
            this.lbl8.Location = new System.Drawing.Point(556, 245);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(52, 17);
            this.lbl8.TabIndex = 39;
            this.lbl8.Text = "DURUM:";
            // 
            // Frm_Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmbBiletAldSeans);
            this.Controls.Add(this.cmbBiletAldFilm);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.mtxtTc);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gridControl1);
            this.Name = "Frm_Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Frm_Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBiletAldFilm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBiletAldSeans.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.LabelControl lbl2;
        private DevExpress.XtraEditors.LabelControl lbl3;
        private DevExpress.XtraEditors.LabelControl lbl6;
        private DevExpress.XtraEditors.LabelControl lbl7;
        private DevExpress.XtraEditors.LabelControl lbl1;
        private DevExpress.XtraEditors.TextEdit txtAD;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.MaskedTextBox mtxtTc;
        private DevExpress.XtraEditors.LabelControl lbl4;
        private DevExpress.XtraEditors.LabelControl lbl5;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBiletAldFilm;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBiletAldSeans;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DevExpress.XtraEditors.LabelControl lbl8;
    }
}