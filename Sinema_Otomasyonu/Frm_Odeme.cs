using DevExpress.XtraEditors;
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
    public partial class Frm_Odeme : Form
    {
        public Frm_Odeme()
        {
            InitializeComponent();
        }
       public int tutar;
        public string ad;
        public string soyad;
        public string tc;
        public string telefon;
        public string film;
        public string seans;
        private void Frm_Odeme_Load(object sender, EventArgs e)
        {
            lblBilgilendirme.Text = "İşleminiz " + tutar.ToString() + " lira tutmuştur";
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnBiletAyır_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_MUSTERİLER (M_Ad,M_Soyad,M_TC,M_Tel,Film,Seans,Durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", ad);
            komut.Parameters.AddWithValue("@p2", soyad);
            komut.Parameters.AddWithValue("@p3", tc);
            komut.Parameters.AddWithValue("@p4", telefon);
            komut.Parameters.AddWithValue("@p5", film);
            komut.Parameters.AddWithValue("@p6", seans);
            if (tutar == 12)
            {
                komut.Parameters.AddWithValue("@p7", "TAM 12 TL");
            }
            else
            {
                komut.Parameters.AddWithValue("@p7", "ÖĞRENCİ 9 TL");
            }
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            XtraMessageBox.Show("Biletiniz Ayırıldı Ödeme İşlemini Sinemada Yapabilirsiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (txtKartNum.Text.Length == 16)
            {
                XtraMessageBox.Show("Ödeme İşleminiz Başarı İle Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand komut = new SqlCommand("Insert into TBL_MUSTERİLER (M_Ad,M_Soyad,M_TC,M_Tel,Film,Seans,Durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1",ad);
                komut.Parameters.AddWithValue("@p2", soyad);
                komut.Parameters.AddWithValue("@p3", tc);
                komut.Parameters.AddWithValue("@p4", telefon);
                komut.Parameters.AddWithValue("@p5", film);
                komut.Parameters.AddWithValue("@p6", seans);
                if (tutar==12)
                {
                    komut.Parameters.AddWithValue("@p7", "TAM 12 TL");
                }
                else
                {
                    komut.Parameters.AddWithValue("@p7", "ÖĞRENCİ 9 TL");
                }
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                XtraMessageBox.Show("Biletiniz  Oluşturuldu Gerekli Bilgiler Telefonunuza İletilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kart Numaranız 16 Hane Olmalı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
