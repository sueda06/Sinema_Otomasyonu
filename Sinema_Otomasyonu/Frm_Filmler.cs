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
    public partial class Frm_Filmler : Form
    {
        public Frm_Filmler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FİLMLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_FİLMLER (FilmAd,FilmTur,FilmSure,FilmBilgi,Oyuncular) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtTur.Text);
            komut.Parameters.AddWithValue("@p3", txtSure.Text);
            komut.Parameters.AddWithValue("@p4", rtxtBilgi.Text);
            komut.Parameters.AddWithValue("@p5", rtxtOyuncular.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Film Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FİLMLER where FilmID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Film Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FİLMLER Set FilmAd=@p1,FilmTur=@p2,FilmSure=@p3,FilmBilgi=@p4,Oyuncular=@p5 where FilmID=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtTur.Text);
            komut.Parameters.AddWithValue("@p3", txtSure.Text);
            komut.Parameters.AddWithValue("@p4", rtxtBilgi.Text);
            komut.Parameters.AddWithValue("@p5", rtxtOyuncular.Text);
            komut.Parameters.AddWithValue("@p6", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Film Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAD.Text = "";
            txtSure.Text = "";
            txtTur.Text = "";
            rtxtBilgi.Text = "";
            rtxtOyuncular.Text = "";
        }
        
        private void Frm_Filmler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["FilmID"].ToString();
                txtAD.Text = dr["FilmAd"].ToString();
                txtTur.Text = dr["FilmTur"].ToString();
                txtSure.Text = dr["FilmSure"].ToString();
                rtxtBilgi.Text = dr["FilmBilgi"].ToString();
                rtxtOyuncular.Text = dr["Oyuncular"].ToString();
            }
        }
    }
}
