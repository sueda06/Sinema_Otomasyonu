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
    public partial class Frm_Kullanicilar : Form
    {
        public Frm_Kullanicilar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_KULLANICILAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_KULLANICILAR (Pozisyon,KullanıcıAdı,Şifre) values(@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPozisyon.Text);
            komut.Parameters.AddWithValue("@p2", txtKulAdı.Text);
            komut.Parameters.AddWithValue("@p3", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Kullanıcı Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Frm_Kullanicilar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_KULLANICILAR where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Kullanıcı Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_KULLANICILAR Set Pozisyon=@p1,KullanıcıAdı=@p2,Şifre=@p3 where ID=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtPozisyon.Text);
            komut.Parameters.AddWithValue("@p2", txtKulAdı.Text);
            komut.Parameters.AddWithValue("@p3",txtSifre.Text);
            komut.Parameters.AddWithValue("@p4",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Kullanıcı Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtKulAdı.Text = "";
            txtPozisyon.Text = "";
            txtSifre.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtPozisyon.Text = dr["Pozisyon"].ToString();
                txtKulAdı.Text = dr["KullanıcıAdı"].ToString();
                txtSifre.Text = dr["Şifre"].ToString();
            }
        }
    }
}
