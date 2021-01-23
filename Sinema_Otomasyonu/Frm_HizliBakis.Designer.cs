namespace Sinema_Otomasyonu
{
    partial class Frm_HizliBakis
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Recep Ivedik 5", new object[] {
            ((object)(20D))}, 0);
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("The Fate of the Furious(2017)", new object[] {
            ((object)(67D))}, 1);
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("Titanic", new object[] {
            ((object)(98D))}, 2);
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("Avatar(2009)", new object[] {
            ((object)(63D))}, 3);
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("Star Wars:The Force Awakens(2015)", new object[] {
            ((object)(94D))}, 4);
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("Avengers:Infinity War (2018)", new object[] {
            ((object)(82D))}, 5);
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("Black Panther", new object[] {
            ((object)(75D))}, 6);
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("Minions", new object[] {
            ((object)(45D))}, 7);
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("Düğün Dernek", new object[] {
            ((object)(81D))}, 9);
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("Fetih 1453", new object[] {
            ((object)(120D))}, 10);
            DevExpress.XtraCharts.SeriesPoint seriesPoint11 = new DevExpress.XtraCharts.SeriesPoint("Müslüm", new object[] {
            ((object)(97D))}, 11);
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HizliBakis));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.listbxHakkımızda = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.ımageSlider2 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listbxHakkımızda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(220)))), ((int)(((byte)(219)))));
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.chartControl1.Diagram = simpleDiagram3D1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(-1, 3);
            this.chartControl1.Name = "chartControl1";
            series1.LegendTextPattern = "{A}";
            series1.Name = "En Tercih Edilen Filmler";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10,
            seriesPoint11});
            series1.View = pie3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(740, 454);
            this.chartControl1.TabIndex = 0;
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AllowLooping = true;
            this.ımageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider1.AutoSlideInterval = 5000;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Location = new System.Drawing.Point(-1, 228);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(743, 229);
            this.ımageSlider1.TabIndex = 1;
            this.ımageSlider1.Text = "ımageSlider1";
            // 
            // listbxHakkımızda
            // 
            this.listbxHakkımızda.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listbxHakkımızda.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.listbxHakkımızda.Appearance.Options.UseBackColor = true;
            this.listbxHakkımızda.Appearance.Options.UseFont = true;
            this.listbxHakkımızda.HorizontalScrollbar = true;
            this.listbxHakkımızda.Location = new System.Drawing.Point(3, 0);
            this.listbxHakkımızda.Name = "listbxHakkımızda";
            this.listbxHakkımızda.Size = new System.Drawing.Size(501, 231);
            this.listbxHakkımızda.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(236, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "FİLMLERİN TERCİH EDİLME ORANLARI";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.Location = new System.Drawing.Point(1, -2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl1.Size = new System.Drawing.Size(749, 485);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.webBrowser1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(742, 451);
            this.xtraTabPage3.Text = "Sinemaya Dair";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(742, 451);
            this.webBrowser1.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.chartControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(742, 451);
            this.xtraTabPage1.Text = "Film Oranları";
            this.xtraTabPage1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xtraTabPage1_MouseClick);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ımageSlider2);
            this.xtraTabPage2.Controls.Add(this.ımageSlider1);
            this.xtraTabPage2.Controls.Add(this.listbxHakkımızda);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(742, 451);
            this.xtraTabPage2.Text = "Hakkımızda";
            this.xtraTabPage2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xtraTabPage2_MouseClick);
            // 
            // ımageSlider2
            // 
            this.ımageSlider2.AllowLooping = true;
            this.ımageSlider2.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider2.AutoSlideInterval = 5000;
            this.ımageSlider2.CurrentImageIndex = 0;
            this.ımageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider2.Images"))));
            this.ımageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider2.Images1"))));
            this.ımageSlider2.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider2.Images2"))));
            this.ımageSlider2.Location = new System.Drawing.Point(507, 0);
            this.ımageSlider2.Name = "ımageSlider2";
            this.ımageSlider2.Size = new System.Drawing.Size(241, 231);
            this.ımageSlider2.TabIndex = 3;
            this.ımageSlider2.Text = "ımageSlider2";
            // 
            // Frm_HizliBakis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 478);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Frm_HizliBakis";
            this.Text = "Hızlı Bakış";
            this.Load += new System.EventHandler(this.Frm_HizliBakis_Load);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listbxHakkımızda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
        private DevExpress.XtraEditors.ListBoxControl listbxHakkımızda;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}