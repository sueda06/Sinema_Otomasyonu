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
    public partial class Frm_Yorumlar : Form
    {
        public Frm_Yorumlar()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_YORUMLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void FilmGetir()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_FİLMLER ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbFilm.Properties.Items.Add(dr[1]);
            }
            bgl.baglanti().Close();
        }
        void YorumGetir()
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_YORUMLAR where FilmAd=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbFilm.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rtxtIsim.Text += dr[1].ToString() + "\n";
                rtxtYorum.Text += dr[2].ToString() + "\n";
                rtxtYorum.Text += "********** \n";
            }
            bgl.baglanti().Close();
        }
        private void Frm_Yorumlar_Load(object sender, EventArgs e)
        {
            Listele();
            FilmGetir();
        }
        string a=null;
        private void btnYorumuGetir_Click(object sender, EventArgs e)
        {
            if (a != cmbFilm.Text)
            {
                a = cmbFilm.Text;
                YorumGetir();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                cmbFilm.Text = dr["FilmAd"].ToString();
                rtxtIsim.Text = dr["İsim"].ToString()+"\n";
                rtxtYorum.Text = dr["Yorum"].ToString()+"\n";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbFilm.Text = "";
            rtxtIsim.Text = "";
            rtxtYorum.Text = "";
        }
    }
}
