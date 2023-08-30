using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonuProjesi
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = LAPTOP - NBQ7RG33\\SQLEXPRESS07; Initial Catalog = HastaneProje; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
