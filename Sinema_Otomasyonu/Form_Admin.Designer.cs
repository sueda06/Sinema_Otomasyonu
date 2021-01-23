namespace Sinema_Otomasyonu
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnFilmler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSeanslar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnOyuncular = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanici = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnFilmler,
            this.BtnSeanslar,
            this.BtnMusteriler,
            this.BtnOyuncular,
            this.btnKullanici});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowItemCaptionsInPageHeader = true;
            this.ribbonControl1.ShowItemCaptionsInQAT = true;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(752, 145);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // BtnFilmler
            // 
            this.BtnFilmler.Caption = "Filmler";
            this.BtnFilmler.Id = 1;
            this.BtnFilmler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFilmler.ImageOptions.Image")));
            this.BtnFilmler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFilmler.ImageOptions.LargeImage")));
            this.BtnFilmler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnFilmler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFilmler.Name = "BtnFilmler";
            this.BtnFilmler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // BtnSeanslar
            // 
            this.BtnSeanslar.Caption = "Seanslar";
            this.BtnSeanslar.Id = 2;
            this.BtnSeanslar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeanslar.ImageOptions.Image")));
            this.BtnSeanslar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSeanslar.ImageOptions.LargeImage")));
            this.BtnSeanslar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSeanslar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnSeanslar.Name = "BtnSeanslar";
            this.BtnSeanslar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSeanslar_ItemClick);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Caption = "Müşteriler";
            this.BtnMusteriler.Id = 3;
            this.BtnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteriler.ImageOptions.Image")));
            this.BtnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteriler.ImageOptions.LargeImage")));
            this.BtnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMusteriler_ItemClick);
            // 
            // BtnOyuncular
            // 
            this.BtnOyuncular.Caption = "Oyuncular";
            this.BtnOyuncular.Id = 4;
            this.BtnOyuncular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOyuncular.ImageOptions.Image")));
            this.BtnOyuncular.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnOyuncular.ImageOptions.LargeImage")));
            this.BtnOyuncular.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnOyuncular.ItemAppearance.Disabled.Options.UseFont = true;
            this.BtnOyuncular.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnOyuncular.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnOyuncular.Name = "BtnOyuncular";
            this.BtnOyuncular.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnOyuncular_ItemClick);
            // 
            // btnKullanici
            // 
            this.btnKullanici.Caption = "Kullanıcılar";
            this.btnKullanici.Id = 5;
            this.btnKullanici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanici.ImageOptions.Image")));
            this.btnKullanici.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullanici.ImageOptions.LargeImage")));
            this.btnKullanici.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnKullanici.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnKullanici.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnKullanici.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullanici_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İşlemler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFilmler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnSeanslar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnOyuncular);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullanici);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = " ";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(752, 653);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnFilmler;
        private DevExpress.XtraBars.BarButtonItem BtnSeanslar;
        private DevExpress.XtraBars.BarButtonItem BtnMusteriler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnOyuncular;
        private DevExpress.XtraBars.BarButtonItem btnKullanici;
    }
}