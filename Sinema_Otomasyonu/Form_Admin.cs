using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }
        Frm_Filmler f1;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f1 == null|| f1.IsDisposed)
            {
                f1 = new Frm_Filmler();
                f1.MdiParent = this;
                f1.Show();
            }
        }
        Frm_Musteriler f3;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(f3== null || f3.IsDisposed)
            {
                f3 = new Frm_Musteriler();
                f3.MdiParent = this;
                f3.Show();
            }
        }

        Frm_Seanslar f2;
        private void BtnSeanslar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(f2==null || f2.IsDisposed)
            {
                f2 = new Frm_Seanslar();
                f2.MdiParent = this;
                f2.Show();
            }
        }
        Frm_Oyuncular f4;
        private void BtnOyuncular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(f4==null || f4.IsDisposed)
            {
                f4 = new Frm_Oyuncular();
                f4.MdiParent = this;
                f4.Show();
            }
        }
        Frm_Kullanicilar f5;
        private void btnKullanici_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(f5==null || f5.IsDisposed)
            {
                f5 = new Frm_Kullanicilar();
                f5.MdiParent = this;
                f5.Show();
            }
        }
    }
}
