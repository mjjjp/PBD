using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Panggil / Import Library SQL
using System.Data.SqlClient;
namespace Penjualan_PBD_TI14GAB_IndahRPutri.Kelas
{
    class Koneksi
    {
        //2. Buat method getconn untuk dapat diakses oleh form lain
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source= INDAH-PC; Initial Catalog=db_penjualan_ti14gab; Integrated Security= True";
            return conn;
        }
    }
}
