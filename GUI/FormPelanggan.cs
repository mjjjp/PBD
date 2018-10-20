using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//4. panggil library SQL
using System.Data.SqlClient;

namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    public partial class FormPelanggan : Form
    {
        //5. tambahkan variabel untuk perintah SQL
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //6. import kelas koneksi dari folder (Kelas/Koneksi.cs) menjadi objek --> konn
        Kelas.Koneksi konn = new Kelas.Koneksi();

        //1. buat prosedur bersih
        void bersih()
        {
            textBox_idpelanggan.Text = "";
            textBox_namapelanggan.Text = "";
            textBox_alamat.Text = "";
            textBox_notelepon.Text = "";
        }
      
        //2. membuat prosedur atur_tombol
        void atur_tombol(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }//tutup prosedur atur_tombol

        //7. membuat prosedur refresh_pelanggan
        public void refresh_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Select * FROM tbl_pelanggan", conn);
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

        //8. membuat prosedur cari_pelanggan
        void cari_pelanggan()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM tbl_pelanggan where IdPelanggan like '%" + textBox_cari.Text +
                        "%' or NamaPelanggan like '%" + textBox_cari.Text + "%' ", conn);
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


        public FormPelanggan()
        {
            InitializeComponent();
            //3. panggil prosedur bersih dan ataur tombol
            bersih();
            atur_tombol(false);
            //9. panggil refresh_pelanggan
            refresh_pelanggan();
            //panggil auto _number
            auto_number();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            //10. panggil cari barang
            cari_pelanggan();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            //11. perintah simpan data pelanggan
            if (textBox_idpelanggan.Text.Trim() == "" || textBox_namapelanggan.Text.Trim() == "" ||
                textBox_alamat.Text.Trim() == "" || textBox_notelepon.Text.Trim() == "")
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
                    cmd = new SqlCommand("INSERT INTO tbl_pelanggan values('" +
                        textBox_idpelanggan.Text + "','" + textBox_namapelanggan.Text +
                        "','" + textBox_alamat.Text + "','" + textBox_notelepon.Text + "')", conn);
                    //Membuka koneksi database
                    conn.Open();
                    //Menjalankan perintah query
                    cmd.ExecuteNonQuery();
                    //Menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data pelanggan berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    bersih();
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void dataGridView_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //12. mengambil nilai dari record table yang dipilih
            try
            {
                button_simpan.Enabled = false;
                atur_tombol(true);
                //Memngisi textbox dan combobox yang akan diparsing dari datagridview
                DataGridViewRow row = this.dataGridView_pelanggan.Rows[e.RowIndex];
                textBox_idpelanggan.Text = row.Cells["IdPelanggan"].Value.ToString();
                textBox_namapelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
                textBox_alamat.Text = row.Cells["Alamat"].Value.ToString();
                textBox_notelepon.Text = row.Cells["NoTelepon"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            //13. Perintah ubah data
            //cek data kosong atau tidak
            if (textBox_idpelanggan.Text.Trim() == "" || textBox_namapelanggan.Text.Trim() == "" ||
                textBox_alamat.Text.Trim() == "" || textBox_notelepon.Text.Trim() == "")
            {
                //Pesan data belum lengkap
                MessageBox.Show("Data Belum Lengkap, Lengkapi Data", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Mempersiapkan sqlconnection
                SqlConnection conn = konn.GetConn();
                try
                {
                    //Memperisiapkan sql command yang akan dieksekusi
                    cmd = new SqlCommand("UPDATE tbl_pelanggan set NamaPelanggan = '" +
                       textBox_namapelanggan.Text + "', Alamat = '" + textBox_alamat.Text + "', NoTelepon = '" +
                       textBox_notelepon.Text + "' where IdPelanggan = '" + textBox_idpelanggan.Text + "'", conn);
                    //Membuka perintah query
                    conn.Open();
                    //Menjalankan perintah query
                    cmd.ExecuteNonQuery();
                    //Menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data pelanggan " + textBox_idpelanggan.Text + " berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pelanggan();
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
            if (MessageBox.Show("Yakin ingin menghapus data " + textBox_namapelanggan.Text + " ?", "Konfigurasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //mempersiapkan sqlconnection
                SqlConnection conn = konn.GetConn();
                {
                    //query menghapus data
                    cmd = new SqlCommand("DELETE FROM tbl_pelanggan where IdPelanggan = '" + textBox_idpelanggan.Text + "'", conn);
                    //buka koneksi database
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //menampilkan pesan
                    MessageBox.Show("Data pelanggan " + textBox_idpelanggan.Text + " berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //memanggil procedure
                    refresh_pelanggan();
                    bersih();
                    atur_tombol(false);
                    auto_number();
                    button_simpan.Enabled = true;
                }
            }
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            //15. panggil prosedur bersih dan atur tombol saat klik baru
            bersih();
            atur_tombol(false);
            auto_number();
            button_simpan.Enabled = true;
        }

        //16. membuat autonumber idpelanggan
        public void auto_number()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT IdPelanggan from tbl_pelanggan where IdPelanggan in (Select max(IdPelanggan) from tbl_pelanggan) order by IdPelanggan desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IdPelanggan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "P001";
            }
            rd.Close();
            textBox_idpelanggan.Enabled = false;
            textBox_idpelanggan.Text = urut;
            conn.Close();
        }
    }
}
