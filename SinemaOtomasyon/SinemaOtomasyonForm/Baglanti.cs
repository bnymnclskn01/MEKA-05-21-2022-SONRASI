using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonForm
{
    public class Baglanti
    {
        public SqlConnection sqlConnection = new SqlConnection(@"Server=89.252.181.210\MSSQLSERVER2014;Database=mekacom_SinemaOtomasyonu;User ID=mekacom_SinemaAdmin;Password=4gl56K!t1;Trusted_Connection=False;");
        public void BaglantiKur()
        {
            if (sqlConnection.State==ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
    }
}
