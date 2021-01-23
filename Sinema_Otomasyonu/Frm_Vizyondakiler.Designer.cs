namespace Sinema_Otomasyonu
{
    partial class Frm_Vizyondakiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Vizyondakiler));
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AllowLooping = true;
            this.ımageSlider1.AnimationTime = 5000;
            this.ımageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider1.AutoSlideInterval = 1000;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images3"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images4"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images5"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images6"))));
            this.ımageSlider1.Location = new System.Drawing.Point(-2, 55);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(745, 420);
            this.ımageSlider1.TabIndex = 0;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(202, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "VIZYONDAKI  FILMLERIMIZ";
            // 
            // Frm_Vizyondakiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ımageSlider1);
            this.Name = "Frm_Vizyondakiler";
            this.Text = "Vizyondakiler";
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}