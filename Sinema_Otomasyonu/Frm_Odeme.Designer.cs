namespace Sinema_Otomasyonu
{
    partial class Frm_Odeme
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
            this.btnBiletAyır = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeYap = new DevExpress.XtraEditors.SimpleButton();
            this.lblBilgilendirme = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKartNum = new DevExpress.XtraEditors.TextEdit();
            this.cmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbYıl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKartNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYıl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBiletAyır
            // 
            this.btnBiletAyır.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnBiletAyır.Appearance.Options.UseFont = true;
            this.btnBiletAyır.Location = new System.Drawing.Point(56, 117);
            this.btnBiletAyır.Name = "btnBiletAyır";
            this.btnBiletAyır.Size = new System.Drawing.Size(300, 29);
            this.btnBiletAyır.TabIndex = 1;
            this.btnBiletAyır.Text = "Bileti Ayır ve Ödemeyi Sinemada Yap";
            this.btnBiletAyır.Click += new System.EventHandler(this.btnBiletAyır_Click);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnOdemeYap.Appearance.Options.UseFont = true;
            this.btnOdemeYap.Location = new System.Drawing.Point(56, 310);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(300, 29);
            this.btnOdemeYap.TabIndex = 2;
            this.btnOdemeYap.Text = "Ödemeyi Yap";
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblBilgilendirme.Appearance.Options.UseFont = true;
            this.lblBilgilendirme.Location = new System.Drawing.Point(56, 67);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(79, 17);
            this.lblBilgilendirme.TabIndex = 3;
            this.lblBilgilendirme.Text = "labelControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 186);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Kart Numarası:";
            // 
            // txtKartNum
            // 
            this.txtKartNum.Location = new System.Drawing.Point(175, 184);
            this.txtKartNum.Name = "txtKartNum";
            this.txtKartNum.Size = new System.Drawing.Size(181, 22);
            this.txtKartNum.TabIndex = 5;
            // 
            // cmbAy
            // 
            this.cmbAy.EditValue = "AY";
            this.cmbAy.Location = new System.Drawing.Point(56, 268);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAy.Properties.Items.AddRange(new object[] {
            "AY",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbAy.Size = new System.Drawing.Size(85, 22);
            this.cmbAy.TabIndex = 6;
            // 
            // cmbYıl
            // 
            this.cmbYıl.EditValue = "YIL";
            this.cmbYıl.Location = new System.Drawing.Point(147, 268);
            this.cmbYıl.Name = "cmbYıl";
            this.cmbYıl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYıl.Properties.Items.AddRange(new object[] {
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbYıl.Size = new System.Drawing.Size(85, 22);
            this.cmbYıl.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 227);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 17);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Son Kullanma Tarihi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(269, 227);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 17);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "CVV:";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(284, 268);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(72, 22);
            this.textEdit2.TabIndex = 10;
            // 
            // Frm_Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 403);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbYıl);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.txtKartNum);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblBilgilendirme);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.btnBiletAyır);
            this.Name = "Frm_Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Odeme";
            this.Load += new System.EventHandler(this.Frm_Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKartNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYıl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnBiletAyır;
        private DevExpress.XtraEditors.SimpleButton btnOdemeYap;
        private DevExpress.XtraEditors.LabelControl lblBilgilendirme;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKartNum;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAy;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYıl;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}