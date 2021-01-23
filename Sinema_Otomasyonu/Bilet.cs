using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void SeansGetir()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_SEANSLAR",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBiletAldSeans.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void FilmGetir()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_Filmler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbBiletAldFilm.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        private void BtnBiletAl_Click(object sender, EventArgs e)
        {
            Frm_Odeme f1 = new Frm_Odeme();
            if (radioButton1.Checked)
            {
                f1.tutar = 9;
            }
            else if (radioButton2.Checked)
            {
                f1.tutar = 12;
            }
            else
            {
                f1.tutar = 0;
            }
            f1.ad = txtAD.Text;
            f1.soyad = txtSoyad.Text;
            f1.tc = mtxtTc.Text;
            f1.telefon = mtxtTelefon.Text;
            f1.film = cmbBiletAldFilm.Text;
            f1.seans = cmbBiletAldSeans.Text;
            f1.Show();
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSoyad.Text = "";
            txtAD.Text = "";
            txtID.Text = "";
            mtxtTc.Text = null;
            mtxtTelefon.Text = null;
            cmbBiletAldFilm.Text = null;
            cmbBiletAldSeans.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                XtraMessageBox.Show("İptal edilecek bilet için telefonunuza gelen ID numarasını giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
              SqlCommand komut = new SqlCommand("Delete From TBL_MUSTERİLER where M_ID=@p1", bgl.baglanti());
              komut.Parameters.AddWithValue("@p1", txtID.Text);
              komut.ExecuteNonQuery();
              bgl.baglanti().Close();
              XtraMessageBox.Show("Biletiniz İptal Edilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Bilet_Load(object sender, EventArgs e)
        {
            SeansGetir();
            FilmGetir();
        }
    }
}
