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
    public partial class Frm_Fragmanlar : Form
    {
        public Frm_Fragmanlar()
        {
            InitializeComponent();
        }

        private void btnYüzEfendisi_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=16ZPrl_I3AM");
        }

        private void btnVandetta_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=jUWcrceo7x8");
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=3zt9z6enRY0");
        }

        private void btnTroy_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=xQ85aYJL_9E&t=9s");
        }

        private void btnYıldızlararsı_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vVJeYMRam0o");
        }

        private void btnTruman_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=TJvUTLVwoHM");
        }

        private void btnHarry_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=5omWAtEKqFc&list=PLErQ3IBHynUjWrj11zUxTvRb_SGmxBUVa");
        }

        private void btnDownfall_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=8i2vzy6XKP8");
        }

        private void btnSherlock_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=cij6sH15bz8");
        }

        private void btnScarface_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Hek-YiVr46E");
        }

        private void btnLeon_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=4Y49duMceDc");
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=SHH9UZlKid0");
        }
    }

}
