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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bilet blt;
        private void btnBiletAl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(blt== null || blt.IsDisposed)
            {
                blt = new Bilet();
                blt.MdiParent = this;
                blt.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Frm_Kategoriler f2;
        private void btnKategoriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Frm_Kategoriler();
                f2.MdiParent = this;
                f2.Show();
            }
        }
       Frm_FilmListesi f1;
        
        private void btnFilmler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (f1== null || f1.IsDisposed)
            {
                f1 = new Frm_FilmListesi();
                f1.MdiParent = this;
                f1.Show();
            }
        }
        Frm_SeansListesi f3;
        private void btnSeanslar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new Frm_SeansListesi();
                f3.MdiParent = this;
                f3.Show();
            }
        }
        Frm_OyuncuListesi f7;
        private void btnOyuncular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(f7==null || f7.IsDisposed)
            {
                f7 = new Frm_OyuncuListesi();
                f7.MdiParent = this;
                f7.Show();
            }
        }
        Frm_Yorumlar f6;
        private void btnYorumlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f6 == null || f6.IsDisposed)
            {
                f6 = new Frm_Yorumlar();
                f6.MdiParent = this;
                f6.Show();
            }
        }
        Frm_Vizyondakiler f4;
        private void btnVizyondakiler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(f4== null || f4.IsDisposed)
            {
                f4 = new Frm_Vizyondakiler();
                f4.MdiParent = this;
                f4.Show();
            }
        }
        Frm_Fragmanlar f5;
        private void btnFragmanlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(f5==null || f5.IsDisposed)
            {
                f5 = new Frm_Fragmanlar();
                f5.MdiParent = this;
                f5.Show();
            }
        }
        Frm_HizliBakis f;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(f==null || f.IsDisposed)
            {
                f = new Frm_HizliBakis();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
