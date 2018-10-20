namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    partial class Menu_Utama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_login = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.submenu_keluar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_master = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_barang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_laporanbrg = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_laporanplgn = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pengaturan = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_ubahpw = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_tambahpengguna = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tentang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolbar_barang = new System.Windows.Forms.ToolStripButton();
            this.toolbar_pelanggan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbar_trasnaksi = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_master,
            this.menu_transaksi,
            this.menu_laporan,
            this.menu_pengaturan,
            this.menu_tentang});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(717, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_login,
            this.submenu_logout,
            this.toolStripMenuItem1,
            this.submenu_keluar});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(37, 20);
            this.menu_file.Text = "&File";
            // 
            // submenu_login
            // 
            this.submenu_login.Name = "submenu_login";
            this.submenu_login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.submenu_login.Size = new System.Drawing.Size(192, 22);
            this.submenu_login.Text = "&Login";
            this.submenu_login.Click += new System.EventHandler(this.submenu_login_Click);
            // 
            // submenu_logout
            // 
            this.submenu_logout.Name = "submenu_logout";
            this.submenu_logout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.submenu_logout.Size = new System.Drawing.Size(192, 22);
            this.submenu_logout.Text = "L&ogout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // submenu_keluar
            // 
            this.submenu_keluar.Name = "submenu_keluar";
            this.submenu_keluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.submenu_keluar.Size = new System.Drawing.Size(192, 22);
            this.submenu_keluar.Text = "&Keluar Aplikasi";
            // 
            // menu_master
            // 
            this.menu_master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_barang,
            this.submenu_pelanggan});
            this.menu_master.Name = "menu_master";
            this.menu_master.Size = new System.Drawing.Size(55, 20);
            this.menu_master.Text = "&Master";
            // 
            // submenu_barang
            // 
            this.submenu_barang.Name = "submenu_barang";
            this.submenu_barang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.submenu_barang.Size = new System.Drawing.Size(171, 22);
            this.submenu_barang.Text = "&Barang";
            this.submenu_barang.Click += new System.EventHandler(this.submenu_barang_Click_1);
            // 
            // submenu_pelanggan
            // 
            this.submenu_pelanggan.Name = "submenu_pelanggan";
            this.submenu_pelanggan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.submenu_pelanggan.Size = new System.Drawing.Size(171, 22);
            this.submenu_pelanggan.Text = "&Pelanggan";
            this.submenu_pelanggan.Click += new System.EventHandler(this.submenu_pelanggan_Click);
            // 
            // menu_transaksi
            // 
            this.menu_transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_penjualan});
            this.menu_transaksi.Name = "menu_transaksi";
            this.menu_transaksi.Size = new System.Drawing.Size(68, 20);
            this.menu_transaksi.Text = "&Transaksi";
            // 
            // submenu_penjualan
            // 
            this.submenu_penjualan.Name = "submenu_penjualan";
            this.submenu_penjualan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.submenu_penjualan.Size = new System.Drawing.Size(166, 22);
            this.submenu_penjualan.Text = "P&enjualan";
            this.submenu_penjualan.Click += new System.EventHandler(this.submenu_penjualan_Click);
            // 
            // menu_laporan
            // 
            this.menu_laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_laporanbrg,
            this.submenu_laporanplgn});
            this.menu_laporan.Name = "menu_laporan";
            this.menu_laporan.Size = new System.Drawing.Size(62, 20);
            this.menu_laporan.Text = "&Laporan";
            // 
            // submenu_laporanbrg
            // 
            this.submenu_laporanbrg.Name = "submenu_laporanbrg";
            this.submenu_laporanbrg.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.submenu_laporanbrg.Size = new System.Drawing.Size(245, 22);
            this.submenu_laporanbrg.Text = "Laporan Data Ba&rang";
            this.submenu_laporanbrg.Click += new System.EventHandler(this.submenu_laporanbrg_Click);
            // 
            // submenu_laporanplgn
            // 
            this.submenu_laporanplgn.Name = "submenu_laporanplgn";
            this.submenu_laporanplgn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.submenu_laporanplgn.Size = new System.Drawing.Size(245, 22);
            this.submenu_laporanplgn.Text = "Laporan Data Pel&anggan";
            this.submenu_laporanplgn.Click += new System.EventHandler(this.submenu_laporanplgn_Click);
            // 
            // menu_pengaturan
            // 
            this.menu_pengaturan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_ubahpw,
            this.submenu_tambahpengguna});
            this.menu_pengaturan.Name = "menu_pengaturan";
            this.menu_pengaturan.Size = new System.Drawing.Size(80, 20);
            this.menu_pengaturan.Text = "&Pengaturan";
            // 
            // submenu_ubahpw
            // 
            this.submenu_ubahpw.Name = "submenu_ubahpw";
            this.submenu_ubahpw.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.submenu_ubahpw.Size = new System.Drawing.Size(218, 22);
            this.submenu_ubahpw.Text = "&Ubah Password";
            // 
            // submenu_tambahpengguna
            // 
            this.submenu_tambahpengguna.Name = "submenu_tambahpengguna";
            this.submenu_tambahpengguna.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.submenu_tambahpengguna.Size = new System.Drawing.Size(218, 22);
            this.submenu_tambahpengguna.Text = "Tambah Pe&ngguna";
            // 
            // menu_tentang
            // 
            this.menu_tentang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_info});
            this.menu_tentang.Name = "menu_tentang";
            this.menu_tentang.Size = new System.Drawing.Size(107, 20);
            this.menu_tentang.Text = "&Tentang Aplikasi";
            // 
            // submenu_info
            // 
            this.submenu_info.Name = "submenu_info";
            this.submenu_info.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.submenu_info.Size = new System.Drawing.Size(132, 22);
            this.submenu_info.Text = "&Info";
            this.submenu_info.Click += new System.EventHandler(this.submenu_info_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbar_barang,
            this.toolbar_pelanggan,
            this.toolStripSeparator1,
            this.toolbar_trasnaksi});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(717, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolbar_barang
            // 
            this.toolbar_barang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_barang.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.item16;
            this.toolbar_barang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_barang.Name = "toolbar_barang";
            this.toolbar_barang.Size = new System.Drawing.Size(23, 22);
            this.toolbar_barang.Text = "Barang";
            this.toolbar_barang.ToolTipText = "Barang";
            // 
            // toolbar_pelanggan
            // 
            this.toolbar_pelanggan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_pelanggan.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.boy16;
            this.toolbar_pelanggan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_pelanggan.Name = "toolbar_pelanggan";
            this.toolbar_pelanggan.Size = new System.Drawing.Size(23, 22);
            this.toolbar_pelanggan.Text = "Pelanggan";
            this.toolbar_pelanggan.ToolTipText = "Pelanggan";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbar_trasnaksi
            // 
            this.toolbar_trasnaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_trasnaksi.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.transaction16;
            this.toolbar_trasnaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_trasnaksi.Name = "toolbar_trasnaksi";
            this.toolbar_trasnaksi.Size = new System.Drawing.Size(23, 22);
            this.toolbar_trasnaksi.Text = "Transaksi";
            this.toolbar_trasnaksi.ToolTipText = "Transaksi";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(717, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(717, 448);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu_Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem menu_file;
        public System.Windows.Forms.ToolStripMenuItem menu_master;
        public System.Windows.Forms.ToolStripMenuItem menu_transaksi;
        public System.Windows.Forms.ToolStripMenuItem menu_laporan;
        public System.Windows.Forms.ToolStripMenuItem menu_pengaturan;
        public System.Windows.Forms.ToolStripMenuItem menu_tentang;
        public System.Windows.Forms.ToolStripButton toolbar_barang;
        public System.Windows.Forms.ToolStripButton toolbar_pelanggan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton toolbar_trasnaksi;
        public System.Windows.Forms.ToolStripMenuItem submenu_login;
        public System.Windows.Forms.ToolStripMenuItem submenu_logout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem submenu_keluar;
        public System.Windows.Forms.ToolStripMenuItem submenu_barang;
        public System.Windows.Forms.ToolStripMenuItem submenu_pelanggan;
        public System.Windows.Forms.ToolStripMenuItem submenu_laporanbrg;
        public System.Windows.Forms.ToolStripMenuItem submenu_penjualan;
        public System.Windows.Forms.ToolStripMenuItem submenu_laporanplgn;
        public System.Windows.Forms.ToolStripMenuItem submenu_info;
        public System.Windows.Forms.ToolStripMenuItem submenu_ubahpw;
        public System.Windows.Forms.ToolStripMenuItem submenu_tambahpengguna;
    }
}



