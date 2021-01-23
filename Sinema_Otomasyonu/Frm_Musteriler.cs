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
using DevExpress.XtraEditors;

namespace Sinema_Otomasyonu
{
    public partial class Frm_Musteriler : Form
    {
        public Frm_Musteriler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERİLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Frm_Musteriler_Load(object sender, EventArgs e)
        {
            Listele();
            SeansGetir();
            FilmGetir();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_MUSTERİLER (M_Ad,M_Soyad,M_TC,M_Tel,Film,Seans,Durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAD.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",mtxtTc.Text);
            komut.Parameters.AddWithValue("@p4",mtxtTelefon.Text);
            komut.Parameters.AddWithValue("@p5",cmbBiletAldFilm.Text);
            komut.Parameters.AddWithValue("@p6",cmbBiletAldSeans.Text);
            if (radioButton1.Checked)
            {
                komut.Parameters.AddWithValue("@p7", radioButton1.Text);
            }
            else
            {
                komut.Parameters.AddWithValue("@p7", radioButton2.Text);
            }
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Müşteri Başarıyla Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAD.Text = "";
            txtSoyad.Text = "";
            mtxtTc.Text = null;
            mtxtTelefon.Text = null;
            cmbBiletAldFilm.Text = null;
            cmbBiletAldSeans.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
           
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_MUSTERİLER where M_ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Müşteri Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_MUSTERİLER Set M_Ad=@p1,M_Soyad=@p2,M_TC=@p3,M_Tel=@p4,Film=@p5,Seans=@p6,Durum=@p7 where M_ID=@p8", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtxtTc.Text);
            komut.Parameters.AddWithValue("@p4", mtxtTelefon.Text);
            komut.Parameters.AddWithValue("@p5", cmbBiletAldFilm.Text);
            komut.Parameters.AddWithValue("@p6", cmbBiletAldSeans.Text);
            if (radioButton1.Checked)
            {
                komut.Parameters.AddWithValue("@p7", radioButton1.Text);
            }
            else
            {
                komut.Parameters.AddWithValue("@p7", radioButton2.Text);
            }
            komut.Parameters.AddWithValue("@p8", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Müşteri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      
        void SeansGetir()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_SEANSLAR", bgl.baglanti());
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
        private void cmbBiletAldSeans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["M_ID"].ToString();
                txtAD.Text = dr["M_Ad"].ToString();
                txtSoyad.Text = dr["M_Soyad"].ToString();
                mtxtTc.Text = dr["M_TC"].ToString();
                mtxtTelefon.Text = dr["M_Tel"].ToString();
                cmbBiletAldFilm.Text = dr["Film"].ToString();
                cmbBiletAldSeans.Text = dr["Seans"].ToString();
               if( dr["Durum"].ToString()== "TAM 12 TL")
                {
                    radioButton2.Checked = true;
                }
               else
                {
                    radioButton1.Checked = true;
                }
            }
        }
    }
}
