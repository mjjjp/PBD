using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1. tambahkan library SQL
using System.Data.SqlClient;

namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    public partial class DialogBarang : Form
    {
        //2. Tambahkan variabel untuk perintah SQL
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        //buat variabel global
        public string kodebarang, namabarang , hargabarang = "";

        //3. import kelas koneksi dari folder (ke objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4. Membuat prosedur refresh_barang
        public void refresh_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM tbl_barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }//tutup prosedur refresh_pelanggan

        public DialogBarang()
        {
            InitializeComponent();
            //5. panggil prosedur saat form pertama kali dijalankan --> constuktor
            refresh_barang();
        }

        //6. buat prosedur cari pelanggan
        public void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM tbl_barang where KodeBarang like '%" +
                        textBox_cari.Text + "%' or NamaBarang like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }//tutup prosedur cari_barang

        private void textBox_cari_TextChanged_1(object sender, EventArgs e)
        {
            //7. Panggil cari_barang
            cari_barang();
        }

        private void dataGridView_barang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //8. Buat fungsi ketika datagrid di double click
            try
            {
                //Mengisi variabel yang akan di parsing dari datagridview
                DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                //variabel yang tadinya kosong akan terisi
                kodebarang = row.Cells["KodeBarang"].Value.ToString();
                namabarang = row.Cells["NamaBarang"].Value.ToString();
                hargabarang = row.Cells["Harga"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        //9. buat function ambil_id_barang
        public string ambil_id_barang
        {
            get
            {
                return kodebarang;
            }
        }

        //10. buat function ambil_nama_barang
        public string ambil_nama_barang
        {
            get
            {
                return namabarang;
            }
        }

        //11. buat function ambil_harga_barang
        public string ambil_harga_barang
        {
            get
            {
                return hargabarang;
            }
        }
    }
}
