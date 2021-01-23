using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class Frm_HizliBakis : Form
    {
        public Frm_HizliBakis()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Frm_HizliBakis_Load(object sender, EventArgs e)
        {

            //SqlCommand da = new SqlCommand("Select Film,Count(M_Ad) From TBL_MUSTERİLER group by Film", bgl.baglanti());
            //SqlDataReader dr = da.ExecuteReader();
            //while (dr.Read())
            //{
            //    chartControl1.Series["En Tercih Edilen Filmler"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            //}

            listbxHakkımızda.Items.Add("HAKKIMIZDA");
            listbxHakkımızda.Items.Add("");
            listbxHakkımızda.Items.Add("ADRESİMİZ: Çiçek Mahallesi Gül Sokak No:23 ANKARA/Çankaya ");
            listbxHakkımızda.Items.Add("TELEFON: 0436 484 4525 \n");
            listbxHakkımızda.Items.Add("FAKS: 0312 123 4589 \n");
            listbxHakkımızda.Items.Add("MAIL: sinemalarca@gmail.com \n");
            listbxHakkımızda.Items.Add("RESMİ HESAPLARIMIZ: Instagram:büyülüfenersineması");
            listbxHakkımızda.Items.Add("Twitter: büyülüfenersineması ");
            listbxHakkımızda.Items.Add("Facebook: büyülüfenersineması");


            webBrowser1.Navigate("http://www.beyazperde.com/haberler/filmler/");
        }

        private void xtraTabPage1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void xtraTabPage2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
