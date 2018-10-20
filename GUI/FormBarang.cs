 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//4. Panggil / Import Library SQL
using System.Data.SqlClient;

namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    public partial class FormBarang : Form
    {
        //5. tambahkan variabel perintah SQL
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //6. Import kelas koneksi dari folder (Kelas/Koneksi.cs) menjadi objek -->konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //1. buat prosedur bersih
        void bersih()
        {
            textBox_kodebarang.Text = "";
            textBox_namabarang.Text = "";
            textBox_harga.Text = "0";
            textBox_stok.Text = "0";
            comboBox_satuan.Text = "-Pilih Satuan-";
        }

        //2.membuat prosedur atur_tombol
        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }//tutup prosedur atur_tombol

        //7. Membuat prosedur refresh_barang
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
        }//tutup prosedur refresh_barang

        //8. Membuat prosedur cari_barang
        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM tbl_barang where KodeBarang like '%" + textBox_cari.Text +
                        "%' or NamaBarang like '%" + textBox_cari.Text + "%' ", conn);
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

        public FormBarang()
        {
            InitializeComponent();
            //3. panggil prosedur bersih dan atur_tombol
            bersih();
            atur_tombol(false);
            //9.panggil refresh barang
            refresh_barang();
            //panggil auto number
            auto_number();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            //10. panggil cari_barang
            cari_barang();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            //11. perintah simpan data barang
            if (textBox_kodebarang.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" ||
                textBox_harga.Text.Trim() == "" || textBox_stok.Text.Trim() == "" ||
                comboBox_satuan.Text.Trim() == "")
            {
                //Pesan data belum lengkap
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Mempersiapkan sqlconnection
                SqlConnection conn = konn.GetConn();
                try
                {
                    //Mempersiapkan sql command tang akan dieksekusi
                    cmd = new SqlCommand("INSERT INTO tbl_barang values('" + textBox_kodebarang.Text + "','" + textBox_namabarang.Text +
                        "','" + textBox_harga.Text + "','" + textBox_stok.Text + "','" + comboBox_satuan.Text + "')", conn);
                    //Mebuka koneksi database
                    conn.Open();
                    //Menjalankan perintah query
                    cmd.ExecuteNonQuery();
                    //Menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data barang berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
                    bersih();
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void dataGridView_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //12. mengambil nilai dari record table yang dipilih
            {
                try
                {
                    button_simpan.Enabled = false;
                    atur_tombol(true);
                    //Mengisi textbox dan combobox yang akan diparsing datri datagridview
                    DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                    textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
                    textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
                    textBox_harga.Text = row.Cells["Harga"].Value.ToString();
                    textBox_stok.Text = row.Cells["Stok"].Value.ToString();
                    comboBox_satuan.Text = row.Cells["Satuan"].Value.ToString();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            //13. Perintah Edit Data
            //cek kosong atau tidak
            if (textBox_kodebarang.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" ||
                textBox_harga.Text.Trim() == "" || textBox_stok.Text.Trim() == "" ||
                comboBox_satuan.Text.Trim() == "")
            {
                //Pesan data belum lengkap
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Mempersiapkan sqlconnection
                SqlConnection conn = konn.GetConn();
                try
                {
                    //Mempersiapkan sqlcommand yang akan dieksekusi
                    cmd = new SqlCommand("UPDATE tbl_barang set NamaBarang = '" +
                        textBox_namabarang.Text + "', Harga = '" + textBox_harga.Text + "', Stok = '"
                        + textBox_stok.Text + "', Satuan = '" + comboBox_satuan.Text + "' where KodeBarang = '" +
                        textBox_kodebarang.Text + "'", conn);
                    //Membuka koneksi database
                    conn.Open();
                    //Menjalankan perintah query
                    cmd.ExecuteNonQuery();
                    //Menampilkan pesan berhasil diubah
                    MessageBox.Show("Data barang " + textBox_kodebarang.Text + " berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                    button_simpan.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            //14. Perintah hapus data
            if (MessageBox.Show("Yakin ingin menghapus data " + textBox_namabarang.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //mempersiapkan sqlconnection
                SqlConnection conn = konn.GetConn();
                {
                    //query menghapus data
                    cmd = new SqlCommand("DELETE FROM tbl_barang where KodeBarang = '" + textBox_kodebarang.Text + "'", conn);
                    //buka koneksi database
                    conn.Open();
                    //eksekusi query
                    cmd.ExecuteNonQuery();
                    //menampilkan pesan
                    MessageBox.Show("Dara barang " + textBox_kodebarang.Text + " berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //memanggil procedure
                    refresh_barang();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                    button_simpan.Enabled = true;
                }
            }   
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            //15. panggil prosedur bersih dan atur_tombol saat klik abaru
            bersih();
            atur_tombol(false);
            auto_number();
            button_simpan.Enabled = true;
        }

        //16. membuat autonumber kodebarang
        public void auto_number()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT KodeBarang from tbl_barang where KodeBarang in (Select max(KodeBarang) from tbl_barang) order by KodeBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "B" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "B001";
            }
            rd.Close();
            textBox_kodebarang.Enabled = false;
            textBox_kodebarang.Text = urut;
            conn.Close();
        }
    }
}
