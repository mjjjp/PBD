using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    public partial class Menu_Utama : Form
    {
        //1.panggil form lain jd objek
        DialogLogin login;
        FormBarang brg;
        FormPelanggan plgn;
        FormTransaksi trx;
        //FormPengguna pggna;
        //DialogAbout dialogabout;

        //2. buat prosedur close_brg
        void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            login = null;
        }
        void brg_FormClosed(object sender, FormClosedEventArgs e)
        {
            brg = null;
        }

        void plgn_FormClosed(object sender, FormClosedEventArgs e)
        {
            plgn = null;
        }

        void trnsksi_FormClosed(Object sender, FormClosedEventArgs e)
        {
            trx = null;
        }

        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void submenu_barang_Click_1(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FormBarang();
                brg.MdiParent = this;
                brg.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void submenu_pelanggan_Click(object sender, EventArgs e)
        {
            if (plgn == null)
            {
                plgn = new FormPelanggan();
                plgn.MdiParent = this;
                plgn.FormClosed += new FormClosedEventHandler(plgn_FormClosed);
                plgn.Show();
            }
            else
            {
                plgn.Activate();
            }
        }

        private void submenu_penjualan_Click(object sender, EventArgs e)
        {
            if (trx == null)
            {
                trx = new FormTransaksi();
                trx.MdiParent = this;
                trx.FormClosed += new FormClosedEventHandler(trnsksi_FormClosed);
                trx.Show();
            }
            else
            {
                trx.Activate();
            }
        }

        private void submenu_info_Click(object sender, EventArgs e)
        {
            DialogAbout f = new DialogAbout();
            f.ShowDialog(this);
        }

        private void submenu_login_Click(object sender, EventArgs e)
        {
            DialogLogin l = new DialogLogin();
            l.ShowDialog(this);
        }

        private void submenu_laporanbrg_Click(object sender, EventArgs e)
        {
            Laporan.CetakBarang a = new Laporan.CetakBarang();
            a.Show();
        }

        private void submenu_laporanplgn_Click(object sender, EventArgs e)
        {
            Laporan.CetakPelanggan a = new Laporan.CetakPelanggan();
            a.Show();
        }
    }
}
