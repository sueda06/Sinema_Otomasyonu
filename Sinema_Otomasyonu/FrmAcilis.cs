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
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;

namespace Sinema_Otomasyonu
{
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }

        private void FrmAcilis_Load(object sender, EventArgs e)
        {
         
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        bool control;
        private void timer1_Tick(object sender, EventArgs e)
        {
           progressBarControl1.Position += 5;
            if (progressBarControl1.Position == 100)
            {
                timer1.Stop();
                SqlCommand komut = new SqlCommand("Select * From TBL_KULLANICILAR where KullanıcıAdı=@p1 and Şifre=@p2 and Pozisyon=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                if (control)
                {
                    komut.Parameters.AddWithValue("@p3", "Müşteri");
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        this.Hide();
                        Form1 fr = new Form1();
                        fr.Show();
                    }
                    else
                    {
                        XtraMessageBox.Show("Kullanıcı Adı veya Şifre hatalıdır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", "Admin");
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        this.Hide();
                        Form_Admin fr1 = new Form_Admin();
                        fr1.Show();
                    }
                    else
                    {
                        XtraMessageBox.Show("Kullanıcı Adı veya Şifre hatalıdır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            control = false;
            progressBarControl1.Position = 0;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            control = true;
            progressBarControl1.Position = 0;
        }
    }
}
