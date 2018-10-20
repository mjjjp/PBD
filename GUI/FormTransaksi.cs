using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//3. tambahkan library SQL
using System.Data.SqlClient;

namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    public partial class FormTransaksi : Form
    {
        //4. tambahkan variabel untuk perintah SQL
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        //5. import kelas koneksi dari folder (Kelas/Koneksi.cs) menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //6. buat prosedur bersih
        private void bersih()
        {
            textBox_nokwitansi.Text = "";
            dateTimePicker_kwitansi.Value = DateTime.Now;
            textBox_idpelanggan.Text = "";
            textBox_namapelanggan.Text = "";
            textBox_kodebarang.Text = "";
            textBox_namabarang.Text = "";
            textBox_hargabarang.Text = "0";
            textBox_jumlah.Text = "0";
            textBox_idpelanggan.Enabled = false;
            textBox_namapelanggan.Enabled = false;
            textBox_kodebarang.Enabled = false;
            textBox_namabarang.Enabled = false;
            textBox_hargabarang.Enabled = false;
            button_minus.Enabled = false;
            button_simpan.Enabled = false;
        }

        //7. membuat prosedur awal
        private void awal()
        {
            //panggil prosedur bersih di dalam prosedur awal
            bersih();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    //buka microsoft sqlserver, membuat view penjualan
                    cmd = new SqlCommand("SELECT * FROM vw_penjualan order by NoKwitansi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");
                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_penjualan";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
                groupBox_transaksi.Enabled = false; //menonaktifkan groupbox data penjualan
            }
        }

        //8. membuat prosedur auto_number
        private void auto_number()
        {
            long hitung;
            string urut;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select NoKwitansi from tbl_penjualan where NoKwitansi in(select max(NoKwitansi) from tbl_penjualan) Order by NoKwitansi desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length - 12, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "Trx-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            }
            else
            {
                urut = "Trx-0001/" + DateTime.Now.ToString("MM/yyyy");
            }
            rd.Close();
            textBox_nokwitansi.Text = urut;
            textBox_nokwitansi.Enabled = false;
            conn.Close();
        }

        public FormTransaksi()
        {
            InitializeComponent();
            //9. memanggil prosedur awal dan auto_number ketika saat pertama kali di jalankan --> constructor
            awal();
            auto_number();
        }

        private void groupBox_form_Enter(object sender, EventArgs e)
        {

        }

        private void button_caripelanggan_Click(object sender, EventArgs e)
        {
            DialogPelanggan plgn = new DialogPelanggan();
            plgn.ShowDialog();
            textBox_idpelanggan.Text = plgn.ambil_id_pelanggan;
            textBox_namapelanggan.Text = plgn.ambil_nama_pelanggan;
        }

        private void button_caribarang_Click(object sender, EventArgs e)
        {
            DialogBarang brg = new DialogBarang();
            brg.ShowDialog();
            textBox_kodebarang.Text = brg.ambil_id_barang;
            textBox_namabarang.Text = brg.ambil_nama_barang;
            textBox_hargabarang.Text = brg.ambil_harga_barang;
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            //10. memanggil prosedur awal dan auto_number ketika button baru dijalankan
            awal();
            auto_number();
            dateTimePicker_kwitansi.Focus();
            button_caripelanggan.Enabled = true;
        }

        //11. prosedur simpan master penjualan
        private void Simpan_MasterPenjualan()
        {
            //mempersiapkan sqlconnection
            SqlConnection conn = konn.GetConn();
            {
                //mempersiapkan sqlcommand yang akan dieksekusi
                cmd = new SqlCommand("insert into tbl_penjualan values('" + textBox_nokwitansi.Text + "','" + dateTimePicker_kwitansi.Text + "','" + textBox_idpelanggan.Text + "')", conn);
                //membuka koneksi database
                conn.Open();
                //menjalankan perintah query
                cmd.ExecuteNonQuery();
            }
        }

        //12. prosedur simpan detail penjualan
        private void Simpan_DetailPenjualan()
        {
            //mempersiapkan sqlconnection
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("insert into tbl_detailpenjualan values('" + textBox_nokwitansi.Text + "','" + textBox_kodebarang.Text + "','" + textBox_jumlah.Text + "')", conn);
                //membuka koneksi database
                conn.Open();
                //menjalankan perintah query
                cmd.ExecuteNonQuery();
            }
        }

        //13. membuat prosedur refresh_penjualan
        private void refresh_penjualan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    //buka microsoft sqlserver, membuat view detail
                    cmd = new SqlCommand("SELECT * FROM vw_detail where NoKwitansi = '" + textBox_nokwitansi.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_detail");
                    dataGridView_transaksi.DataSource = ds;
                    dataGridView_transaksi.DataMember = "vw_detail";
                    dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_transaksi.AllowUserToAddRows = false;
                    dataGridView_transaksi.Refresh();
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
        }

        //14. prosedur refresh transaksi per barang
        private void RefreshTransaksi()
        {
            //memanggil prosedur refresh penjualan dan bersihkan beberapa komponen transaksi barang
            refresh_penjualan();
            textBox_kodebarang.Clear();
            textBox_namabarang.Clear();
            textBox_hargabarang.Text = "0";
            textBox_jumlah.Text = "0";
            textBox_jumlah.Focus();
        }

        //15. prosedur refresh totalseluruh
        private void totalseluruh()
        {
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select sum(Harga*Jumlah) as TotalBayar from vw_detail where NoKwitansi = '" +
                    textBox_nokwitansi.Text + "' ", conn);
                cmd.Connection = conn;
                int result = ((int)cmd.ExecuteScalar());
                string TotalSeluruh = result.ToString();
                label_totalseluruh.Text = result.ToString();
                conn.Close();
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            //16. simpan data penjualan per barang (buat triger dahulu di sql server untuk automasi stok)
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                //jika ada data yang kosong
                if (textBox_nokwitansi.Text.Trim() == "" || textBox_idpelanggan.Text.Trim() == "" ||
                    textBox_kodebarang.Text.Trim() == "" || textBox_jumlah.Text.Trim() == "")
                {
                    //pesan data belum lengkap
                    MessageBox.Show("Data belum lengkap, lengkapi data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //jika data sudah terisi semua
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from tbl_penjualan where NoKwitansi = '" + textBox_nokwitansi.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())//jika data penjualan sudah ada
                    {
                        //memanggil prosedur detail pejualan
                        Simpan_DetailPenjualan();
                        //panggil prosedur totalseluruh
                        totalseluruh();
                    }
                    else //jika data penjualan belum ada
                    {
                        //memanggil prosedur simpan master dan detail penjualan
                        Simpan_MasterPenjualan();
                        Simpan_DetailPenjualan();
                        //panggil prosedur totalseluruh
                        totalseluruh();
                    }
                    button_caripelanggan.Enabled = false;
                    button_simpan.Enabled = true;
                    groupBox_transaksi.Enabled = true; //aktifkan group box data penjualan
                    //memanggil prosedur refresh transaksi
                    RefreshTransaksi();
                }
            }
        }

        private void dataGridView_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //17. Tampilkan Data Penjualan Per Barang
            button_plus.Enabled = false;
            button_minus.Enabled = true;
            DataGridViewRow row = this.dataGridView_transaksi.Rows[e.RowIndex];
            textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
            textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
            textBox_hargabarang.Text = row.Cells["Harga"].Value.ToString();
            textBox_jumlah.Text = row.Cells["Jumlah"].Value.ToString();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            //18. hapus data penjualan per barang
            //memperisapkan koneksi database
            SqlConnection conn = konn.GetConn();
            {
                //query menghapus data berdasarkan Nomor Kwitansi
                cmd = new SqlCommand("delete from tbl_detailpenjualan where NoKwitansi = '" + textBox_nokwitansi.Text + "' AND KodeBarang = '" + textBox_kodebarang.Text + "'", conn);
                //buka koneksi database
                conn.Open();
                //eksekusi query
                cmd.ExecuteNonQuery();
                //panggil prosedur totalseluruh
                totalseluruh();
                //panggil prosedur refresh transaksi
                RefreshTransaksi();
                button_plus.Enabled = true;
                button_minus.Enabled = false;
            }
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            //19. transaksi selesai
            MessageBox.Show("Transaksi Selesai");
            //panggil form laporan transaksi
            Laporan.CetakTransaksi a = new Laporan.CetakTransaksi(textBox_nokwitansi.Text);
            a.Show();

            //kembali ke baru
            awal();
            label_totalseluruh.Text = "0";
            button_caripelanggan.Enabled = true;
            //panggil auto number
            auto_number();
        }
    }
}