using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Sinema_Otomasyonu
{
    public partial class Frm_Seanslar : Form
    {
        public Frm_Seanslar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_SEANSLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_SEANSLAR (Saat,Adı) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSaat.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Yeni Seans Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_SEANSLAR where S_ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Seans Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Frm_Seanslar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSaat.Text = "";
            txtAd.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_SEANSLAR Set Saat=@p1, Adı=@p2 where S_ID=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSaat.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            XtraMessageBox.Show("Seans Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["S_ID"].ToString();
                txtAd.Text = dr["Adı"].ToString();
                txtSaat.Text = dr["Saat"].ToString();
               
            }
        }
    }
}
