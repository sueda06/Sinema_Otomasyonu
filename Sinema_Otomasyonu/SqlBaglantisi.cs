using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Sinema_Otomasyonu
{
    class SqlBaglantisi
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\Adresim.txt");
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(Adres);
            baglan.Open();
            return baglan;
        }
    }
}
