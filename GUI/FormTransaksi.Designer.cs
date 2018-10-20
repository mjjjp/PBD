namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    partial class FormTransaksi
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
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_kwitansi = new System.Windows.Forms.DateTimePicker();
            this.button_caripelanggan = new System.Windows.Forms.Button();
            this.textBox_namapelanggan = new System.Windows.Forms.TextBox();
            this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
            this.textBox_nokwitansi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_transaksi = new System.Windows.Forms.GroupBox();
            this.dataGridView_transaksi = new System.Windows.Forms.DataGridView();
            this.groupBox_barang = new System.Windows.Forms.GroupBox();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_caribarang = new System.Windows.Forms.Button();
            this.textBox_jumlah = new System.Windows.Forms.TextBox();
            this.textBox_hargabarang = new System.Windows.Forms.TextBox();
            this.textBox_namabarang = new System.Windows.Forms.TextBox();
            this.textBox_kodebarang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_totalseluruh = new System.Windows.Forms.Label();
            this.button_baru = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_transaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).BeginInit();
            this.groupBox_barang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.pictureBox1);
            this.groupBox_form.Controls.Add(this.dateTimePicker_kwitansi);
            this.groupBox_form.Controls.Add(this.button_caripelanggan);
            this.groupBox_form.Controls.Add(this.textBox_namapelanggan);
            this.groupBox_form.Controls.Add(this.textBox_idpelanggan);
            this.groupBox_form.Controls.Add(this.textBox_nokwitansi);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(13, 13);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(369, 208);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "From Transaksi Penjualan";
            this.groupBox_form.Enter += new System.EventHandler(this.groupBox_form_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.transaction64;
            this.pictureBox1.Location = new System.Drawing.Point(6, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker_kwitansi
            // 
            this.dateTimePicker_kwitansi.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_kwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_kwitansi.Location = new System.Drawing.Point(225, 80);
            this.dateTimePicker_kwitansi.Name = "dateTimePicker_kwitansi";
            this.dateTimePicker_kwitansi.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker_kwitansi.TabIndex = 9;
            // 
            // button_caripelanggan
            // 
            this.button_caripelanggan.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.search16;
            this.button_caripelanggan.Location = new System.Drawing.Point(148, 161);
            this.button_caripelanggan.Name = "button_caripelanggan";
            this.button_caripelanggan.Size = new System.Drawing.Size(39, 27);
            this.button_caripelanggan.TabIndex = 8;
            this.button_caripelanggan.UseVisualStyleBackColor = true;
            this.button_caripelanggan.Click += new System.EventHandler(this.button_caripelanggan_Click);
            // 
            // textBox_namapelanggan
            // 
            this.textBox_namapelanggan.Location = new System.Drawing.Point(193, 161);
            this.textBox_namapelanggan.Name = "textBox_namapelanggan";
            this.textBox_namapelanggan.Size = new System.Drawing.Size(164, 27);
            this.textBox_namapelanggan.TabIndex = 7;
            // 
            // textBox_idpelanggan
            // 
            this.textBox_idpelanggan.Location = new System.Drawing.Point(6, 161);
            this.textBox_idpelanggan.Name = "textBox_idpelanggan";
            this.textBox_idpelanggan.Size = new System.Drawing.Size(136, 27);
            this.textBox_idpelanggan.TabIndex = 6;
            // 
            // textBox_nokwitansi
            // 
            this.textBox_nokwitansi.Location = new System.Drawing.Point(225, 35);
            this.textBox_nokwitansi.Name = "textBox_nokwitansi";
            this.textBox_nokwitansi.Size = new System.Drawing.Size(132, 27);
            this.textBox_nokwitansi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tgl Kwitansi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Kwitansi";
            // 
            // groupBox_transaksi
            // 
            this.groupBox_transaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_transaksi.Controls.Add(this.dataGridView_transaksi);
            this.groupBox_transaksi.Location = new System.Drawing.Point(388, 13);
            this.groupBox_transaksi.Name = "groupBox_transaksi";
            this.groupBox_transaksi.Size = new System.Drawing.Size(391, 387);
            this.groupBox_transaksi.TabIndex = 1;
            this.groupBox_transaksi.TabStop = false;
            this.groupBox_transaksi.Text = "Data Transaksi";
            // 
            // dataGridView_transaksi
            // 
            this.dataGridView_transaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transaksi.Location = new System.Drawing.Point(6, 26);
            this.dataGridView_transaksi.Name = "dataGridView_transaksi";
            this.dataGridView_transaksi.Size = new System.Drawing.Size(379, 353);
            this.dataGridView_transaksi.TabIndex = 0;
            this.dataGridView_transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_transaksi_CellDoubleClick);
            // 
            // groupBox_barang
            // 
            this.groupBox_barang.Controls.Add(this.button_minus);
            this.groupBox_barang.Controls.Add(this.button_plus);
            this.groupBox_barang.Controls.Add(this.button_caribarang);
            this.groupBox_barang.Controls.Add(this.textBox_jumlah);
            this.groupBox_barang.Controls.Add(this.textBox_hargabarang);
            this.groupBox_barang.Controls.Add(this.textBox_namabarang);
            this.groupBox_barang.Controls.Add(this.textBox_kodebarang);
            this.groupBox_barang.Controls.Add(this.label9);
            this.groupBox_barang.Controls.Add(this.label8);
            this.groupBox_barang.Controls.Add(this.label7);
            this.groupBox_barang.Controls.Add(this.label6);
            this.groupBox_barang.Location = new System.Drawing.Point(12, 227);
            this.groupBox_barang.Name = "groupBox_barang";
            this.groupBox_barang.Size = new System.Drawing.Size(370, 173);
            this.groupBox_barang.TabIndex = 2;
            this.groupBox_barang.TabStop = false;
            this.groupBox_barang.Text = "Ambil Barang";
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(327, 140);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(31, 25);
            this.button_minus.TabIndex = 10;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(284, 140);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(31, 25);
            this.button_plus.TabIndex = 9;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_caribarang
            // 
            this.button_caribarang.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.search16;
            this.button_caribarang.Location = new System.Drawing.Point(149, 58);
            this.button_caribarang.Name = "button_caribarang";
            this.button_caribarang.Size = new System.Drawing.Size(39, 27);
            this.button_caribarang.TabIndex = 8;
            this.button_caribarang.UseVisualStyleBackColor = true;
            this.button_caribarang.Click += new System.EventHandler(this.button_caribarang_Click);
            // 
            // textBox_jumlah
            // 
            this.textBox_jumlah.Location = new System.Drawing.Point(181, 124);
            this.textBox_jumlah.Name = "textBox_jumlah";
            this.textBox_jumlah.Size = new System.Drawing.Size(87, 27);
            this.textBox_jumlah.TabIndex = 7;
            // 
            // textBox_hargabarang
            // 
            this.textBox_hargabarang.Location = new System.Drawing.Point(10, 124);
            this.textBox_hargabarang.Name = "textBox_hargabarang";
            this.textBox_hargabarang.Size = new System.Drawing.Size(117, 27);
            this.textBox_hargabarang.TabIndex = 6;
            // 
            // textBox_namabarang
            // 
            this.textBox_namabarang.Location = new System.Drawing.Point(194, 58);
            this.textBox_namabarang.Name = "textBox_namabarang";
            this.textBox_namabarang.Size = new System.Drawing.Size(164, 27);
            this.textBox_namabarang.TabIndex = 5;
            // 
            // textBox_kodebarang
            // 
            this.textBox_kodebarang.Location = new System.Drawing.Point(6, 58);
            this.textBox_kodebarang.Name = "textBox_kodebarang";
            this.textBox_kodebarang.Size = new System.Drawing.Size(137, 27);
            this.textBox_kodebarang.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Harga Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nama Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kode Barang";
            // 
            // label_totalseluruh
            // 
            this.label_totalseluruh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalseluruh.AutoSize = true;
            this.label_totalseluruh.Location = new System.Drawing.Point(654, 425);
            this.label_totalseluruh.Name = "label_totalseluruh";
            this.label_totalseluruh.Size = new System.Drawing.Size(17, 20);
            this.label_totalseluruh.TabIndex = 3;
            this.label_totalseluruh.Text = "0";
            // 
            // button_baru
            // 
            this.button_baru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_baru.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.new32;
            this.button_baru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baru.Location = new System.Drawing.Point(12, 412);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(122, 47);
            this.button_baru.TabIndex = 4;
            this.button_baru.Text = "Baru";
            this.button_baru.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_simpan.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.save32;
            this.button_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simpan.Location = new System.Drawing.Point(250, 412);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(132, 47);
            this.button_simpan.TabIndex = 5;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Seluruh Rp";
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 485);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_baru);
            this.Controls.Add(this.label_totalseluruh);
            this.Controls.Add(this.groupBox_barang);
            this.Controls.Add(this.groupBox_transaksi);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Transaksi";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_transaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).EndInit();
            this.groupBox_barang.ResumeLayout(false);
            this.groupBox_barang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.GroupBox groupBox_transaksi;
        private System.Windows.Forms.GroupBox groupBox_barang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_namapelanggan;
        private System.Windows.Forms.TextBox textBox_idpelanggan;
        private System.Windows.Forms.TextBox textBox_nokwitansi;
        private System.Windows.Forms.Label label_totalseluruh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_jumlah;
        private System.Windows.Forms.TextBox textBox_hargabarang;
        private System.Windows.Forms.TextBox textBox_namabarang;
        private System.Windows.Forms.TextBox textBox_kodebarang;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_caripelanggan;
        private System.Windows.Forms.Button button_caribarang;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kwitansi;
        private System.Windows.Forms.DataGridView dataGridView_transaksi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}