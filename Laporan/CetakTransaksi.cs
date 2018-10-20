using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2.
using System.Data.SqlClient;
//3. tambah library crystal engine
using CrystalDecisions.CrystalReports.Engine;


namespace Penjualan_PBD_TI14GAB_IndahRPutri.Laporan
{
    public partial class CetakTransaksi : Form
    {
        //4. tambahkan variabel untuk perintah SQL
        private DataSet ds;
        private SqlDataAdapter da;

        //5. variabel untuk jadi parameter nokwitansi yang akan di cetak
        private string text_kwitansi;

        //6. import kelas koneksi dari folder (Kelas/Koneksi.cs) menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //1. rubah terlebih dahulu laporan transaksi menjadi function dengan parameter sehingga nanti laporan transaksi akan menerima no kwitansi dari formtransaksi
        public CetakTransaksi(string nokwitansi)
        {
            InitializeComponent();
            //7. isi variabel text_kwitansi sesuai dengan nokwitansu yang didapat dari formtransaksi
            text_kwitansi = nokwitansi;
        }

        //8. void cetak
        void cetak()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                da = new SqlDataAdapter("select * from vw_cetaktransaksi where NoKwitansi = '" + text_kwitansi + "'", conn);
                ds = new DataSet();
                da.Fill(ds, "vw_cetaktransaksi");
                report_transaksi myreport = new report_transaksi();
                myreport.SetDataSource(ds);
                crystalReportViewer1.ReportSource = myreport;
                crystalReportViewer1.Refresh();
            }
        }

        private void CetakTransaksi_Load(object sender, EventArgs e)
        {
            //9. panggil pada saat laporantransaksi terload
            cetak();
        }
    }
}
