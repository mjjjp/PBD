using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1.
using System.Data.SqlClient;
//2.
using CrystalDecisions.CrystalReports.Engine;


namespace Penjualan_PBD_TI14GAB_IndahRPutri.Laporan
{
    public partial class CetakPelanggan : Form
    {
        //3. tambahkan variabel untuk perintah SQL
        private DataSet ds;
        private SqlDataAdapter da;

        //4. import kelas koneksi dari folder (Kelas/Koneksi.cs) menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //5. void cetak
        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("select * from tbl_pelanggan order by IdPelanggan asc", conn);
                ds = new DataSet();
                da.Fill(ds, "tbl_barang");
                report_pelanggan myreport = new report_pelanggan();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
            }
        }

        public CetakPelanggan()
        {
            InitializeComponent();
            cetak();
        }
    }
}
