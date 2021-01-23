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
    public partial class Frm_Oyuncular : Form
    {
        public Frm_Oyuncular()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_OYUNCULAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Frm_Oyuncular_Load(object sender, EventArgs e)
        {
            Listele();
        }
      
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_OYUNCULAR where OyuncuID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Oyuncu Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_OYUNCULAR Set OyuncuAd=@p1,OyuncuSoyad=@p2,OyuncuYas=@p3,OynadıgıFilmler=@p4 where OyuncuID=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtYas.Text);
            komut.Parameters.AddWithValue("@p4", rtxtOynFilmler.Text);
            komut.Parameters.AddWithValue("@p5", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Oyuncu Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAD.Text = "";
            txtSoyad.Text = "";
            txtYas.Text = "";
            rtxtOynFilmler.Text = "";
        }

        private void BtnEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_OYUNCULAR (OyuncuAd,OyuncuSoyad,OyuncuYas,OynadıgıFilmler) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtYas.Text);
            komut.Parameters.AddWithValue("@p4", rtxtOynFilmler.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Oyuncu Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["OyuncuID"].ToString();
                txtAD.Text = dr["OyuncuAd"].ToString();
                txtSoyad.Text = dr["OyuncuSoyad"].ToString();
                txtYas.Text = dr["OyuncuYas"].ToString();
                rtxtOynFilmler.Text = dr["OynadıgıFilmler"].ToString();
            }

        }
    }
}
