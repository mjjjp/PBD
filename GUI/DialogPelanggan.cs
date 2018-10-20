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
    public partial class DialogPelanggan : Form
    {
        //2. Tambahkan variabel untuk perintah SQL
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        //buat variabel global
        public string idpelanggan, namapelanggan = "";

        //3. import kelas koneksi dari folder (ke objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //4. Membuat prosedur refresh_pelanggan
        public void refresh_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM tbl_pelanggan", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_pelanggan.DataSource = ds;
                    dataGridView_pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_pelanggan.AllowUserToAddRows = false;
                    dataGridView_pelanggan.Refresh();
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

        public DialogPelanggan()
        {
            InitializeComponent();
            //5. panggil prosedur saat form pertama kali dijalankan --> constuktor
            refresh_pelanggan();
        }

        //6. buat prosedur cari pelanggan
        public void cari_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM tbl_pelanggan where IdPelanggan like '%" +
                        textBox_cari.Text + "%' or NamaPelanggan like '%" + textBox_cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_pelanggan.DataSource = ds;
                    dataGridView_pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_pelanggan.AllowUserToAddRows = false;
                    dataGridView_pelanggan.Refresh();
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
        }//tutup prosedur cari_pelanggan

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            //7. Panggil cari_pelanggan
            cari_pelanggan();
        }

        private void dataGridView_pelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //8. Buat fungsi ketika datagrid di double click
            try
            {
                //Mengisi variabel yang akan di parsing dari datagridview
                DataGridViewRow row = this.dataGridView_pelanggan.Rows[e.RowIndex];
                //variabel yang tadinya kosong akan terisi
                idpelanggan = row.Cells["IdPelanggan"].Value.ToString();
                namapelanggan = row.Cells["NamaPelanggan"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        //9. buat function ambil_id_pelanggan
        public string ambil_id_pelanggan
        {
            get
            {
                return idpelanggan;
            }
        }

        //10. buat function ambil_nama_pelanggan
        public string ambil_nama_pelanggan
        {
            get
            {
                return namapelanggan;
            }
        }
    }
}
