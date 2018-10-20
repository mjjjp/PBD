namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    partial class FormPelanggan
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
            this.textBox_notelepon = new System.Windows.Forms.TextBox();
            this.textBox_alamat = new System.Windows.Forms.TextBox();
            this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
            this.textBox_namapelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.dataGridView_pelanggan = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_form.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).BeginInit();
            this.groupBox_proses.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.textBox_notelepon);
            this.groupBox_form.Controls.Add(this.textBox_alamat);
            this.groupBox_form.Controls.Add(this.textBox_idpelanggan);
            this.groupBox_form.Controls.Add(this.textBox_namapelanggan);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(13, 13);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(328, 301);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "Form Pelanggan";
            // 
            // textBox_notelepon
            // 
            this.textBox_notelepon.Location = new System.Drawing.Point(148, 244);
            this.textBox_notelepon.Name = "textBox_notelepon";
            this.textBox_notelepon.Size = new System.Drawing.Size(174, 29);
            this.textBox_notelepon.TabIndex = 7;
            // 
            // textBox_alamat
            // 
            this.textBox_alamat.Location = new System.Drawing.Point(148, 116);
            this.textBox_alamat.Multiline = true;
            this.textBox_alamat.Name = "textBox_alamat";
            this.textBox_alamat.Size = new System.Drawing.Size(174, 113);
            this.textBox_alamat.TabIndex = 6;
            // 
            // textBox_idpelanggan
            // 
            this.textBox_idpelanggan.Location = new System.Drawing.Point(148, 28);
            this.textBox_idpelanggan.Name = "textBox_idpelanggan";
            this.textBox_idpelanggan.Size = new System.Drawing.Size(174, 29);
            this.textBox_idpelanggan.TabIndex = 4;
            // 
            // textBox_namapelanggan
            // 
            this.textBox_namapelanggan.Location = new System.Drawing.Point(148, 72);
            this.textBox_namapelanggan.Name = "textBox_namapelanggan";
            this.textBox_namapelanggan.Size = new System.Drawing.Size(174, 29);
            this.textBox_namapelanggan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Pelanggan";
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Controls.Add(this.dataGridView_pelanggan);
            this.groupBox_data.Controls.Add(this.label5);
            this.groupBox_data.Location = new System.Drawing.Point(347, 13);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(413, 452);
            this.groupBox_data.TabIndex = 1;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data Pelanggan";
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(204, 22);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(201, 29);
            this.textBox_cari.TabIndex = 1;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // dataGridView_pelanggan
            // 
            this.dataGridView_pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pelanggan.Location = new System.Drawing.Point(8, 57);
            this.dataGridView_pelanggan.Name = "dataGridView_pelanggan";
            this.dataGridView_pelanggan.Size = new System.Drawing.Size(397, 386);
            this.dataGridView_pelanggan.TabIndex = 2;
            this.dataGridView_pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pelanggan_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cari Pelanggan (ID/Nama)";
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Location = new System.Drawing.Point(13, 320);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Size = new System.Drawing.Size(328, 145);
            this.groupBox_proses.TabIndex = 2;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = "Proses";
            // 
            // button_ubah
            // 
            this.button_ubah.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.edit32;
            this.button_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ubah.Location = new System.Drawing.Point(11, 80);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(146, 46);
            this.button_ubah.TabIndex = 2;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.delete32;
            this.button_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hapus.Location = new System.Drawing.Point(163, 80);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(159, 46);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.save32;
            this.button_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simpan.Location = new System.Drawing.Point(163, 28);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(159, 46);
            this.button_simpan.TabIndex = 1;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_baru
            // 
            this.button_baru.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.new32;
            this.button_baru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baru.Location = new System.Drawing.Point(11, 28);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(146, 46);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 477);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPelanggan";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).EndInit();
            this.groupBox_proses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_notelepon;
        private System.Windows.Forms.TextBox textBox_alamat;
        private System.Windows.Forms.TextBox textBox_namapelanggan;
        private System.Windows.Forms.TextBox textBox_idpelanggan;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.DataGridView dataGridView_pelanggan;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
    }
}