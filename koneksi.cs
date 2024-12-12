using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Aplikasi_Kasir
{
    internal class Koneksi
    {
        //2
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data source=THINKPAD-X395\\SQLEXPRESS;initial catalog=db_kasir; integrated security=true";
            return Conn;
        }

    }
} 