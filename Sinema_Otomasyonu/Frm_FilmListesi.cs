﻿using System;
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
    public partial class Frm_FilmListesi : Form
    {
        public Frm_FilmListesi()
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

        private void Frm_FilmListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
