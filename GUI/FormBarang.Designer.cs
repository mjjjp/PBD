namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    partial class FormBarang
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.comboBox_satuan = new System.Windows.Forms.ComboBox();
            this.textBox_stok = new System.Windows.Forms.TextBox();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.textBox_namabarang = new System.Windows.Forms.TextBox();
            this.textBox_kodebarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.groupBox_form.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.groupBox_proses.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.comboBox_satuan);
            this.groupBox_form.Controls.Add(this.textBox_stok);
            this.groupBox_form.Controls.Add(this.textBox_harga);
            this.groupBox_form.Controls.Add(this.textBox_namabarang);
            this.groupBox_form.Controls.Add(this.textBox_kodebarang);
            this.groupBox_form.Controls.Add(this.label5);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(12, 12);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(309, 248);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "FormBarang";
            // 
            // comboBox_satuan
            // 
            this.comboBox_satuan.FormattingEnabled = true;
            this.comboBox_satuan.Items.AddRange(new object[] {
            "Unit",
            "Lusin",
            "Kodi",
            "Pack",
            "Dus"});
            this.comboBox_satuan.Location = new System.Drawing.Point(141, 199);
            this.comboBox_satuan.Name = "comboBox_satuan";
            this.comboBox_satuan.Size = new System.Drawing.Size(162, 28);
            this.comboBox_satuan.TabIndex = 9;
            // 
            // textBox_stok
            // 
            this.textBox_stok.Location = new System.Drawing.Point(141, 154);
            this.textBox_stok.Name = "textBox_stok";
            this.textBox_stok.Size = new System.Drawing.Size(100, 27);
            this.textBox_stok.TabIndex = 8;
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(141, 113);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(162, 27);
            this.textBox_harga.TabIndex = 7;
            // 
            // textBox_namabarang
            // 
            this.textBox_namabarang.Location = new System.Drawing.Point(141, 75);
            this.textBox_namabarang.Name = "textBox_namabarang";
            this.textBox_namabarang.Size = new System.Drawing.Size(162, 27);
            this.textBox_namabarang.TabIndex = 6;
            // 
            // textBox_kodebarang
            // 
            this.textBox_kodebarang.Location = new System.Drawing.Point(141, 36);
            this.textBox_kodebarang.Name = "textBox_kodebarang";
            this.textBox_kodebarang.Size = new System.Drawing.Size(100, 27);
            this.textBox_kodebarang.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.dataGridView_barang);
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Controls.Add(this.label6);
            this.groupBox_data.Location = new System.Drawing.Point(327, 12);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(395, 387);
            this.groupBox_data.TabIndex = 1;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "DataBarang";
            // 
            // dataGridView_barang
            // 
            this.dataGridView_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barang.Location = new System.Drawing.Point(9, 62);
            this.dataGridView_barang.Name = "dataGridView_barang";
            this.dataGridView_barang.Size = new System.Drawing.Size(377, 312);
            this.dataGridView_barang.TabIndex = 2;
            this.dataGridView_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellClick);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(197, 26);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(186, 27);
            this.textBox_cari.TabIndex = 1;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = " Cari Barang (Kode/Nama)";
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Location = new System.Drawing.Point(12, 266);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(309, 133);
            this.groupBox_proses.TabIndex = 2;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = "Proses";
            // 
            // button_hapus
            // 
            this.button_hapus.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.delete32;
            this.button_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hapus.Location = new System.Drawing.Point(159, 84);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(143, 36);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.edit32;
            this.button_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ubah.Location = new System.Drawing.Point(11, 84);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(143, 36);
            this.button_ubah.TabIndex = 2;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_baru
            // 
            this.button_baru.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.new32;
            this.button_baru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baru.Location = new System.Drawing.Point(10, 26);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(143, 38);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "Baru";
            this.button_baru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.save32;
            this.button_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simpan.Location = new System.Drawing.Point(159, 26);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(143, 38);
            this.button_simpan.TabIndex = 1;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 425);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarang";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
            this.groupBox_proses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_satuan;
        private System.Windows.Forms.TextBox textBox_stok;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.TextBox textBox_namabarang;
        private System.Windows.Forms.TextBox textBox_kodebarang;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.DataGridView dataGridView_barang;
    }
}