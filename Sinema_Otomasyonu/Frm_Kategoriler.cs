using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class Frm_Kategoriler : Form
    {
        public Frm_Kategoriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Aksiyon()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Aksiyon'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbAksiyon.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void Komedi()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Komedi'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKomedi.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void Dram()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Dram'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDram.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void Macera()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Macera'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbMacera.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void Belgesel()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Belgesel'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBelgesel.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void Korku()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Korku'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKorku.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void BilimKurgu()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Bilim Kurgu'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBilimKurgu.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void RomantikKomedi()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Romantik Komedi'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbRomantikKomedi.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void Polisiye()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Polisiye'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbPolisiye.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void Biyografi()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER where FilmTur='Biyografi'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBiyografi.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        private void Frm_Kategoriler_Load(object sender, EventArgs e)
        {
            Aksiyon();
            Komedi();
            Dram();
            Macera();
            Belgesel();
            Korku();
            BilimKurgu();
            RomantikKomedi();
            Polisiye();
            Biyografi();
        }
    }
}
