namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    partial class DialogPelanggan
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
            this.groupBox_pelanggan = new System.Windows.Forms.GroupBox();
            this.dataGridView_pelanggan = new System.Windows.Forms.DataGridView();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_pelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_pelanggan
            // 
            this.groupBox_pelanggan.Controls.Add(this.dataGridView_pelanggan);
            this.groupBox_pelanggan.Controls.Add(this.textBox_cari);
            this.groupBox_pelanggan.Controls.Add(this.label1);
            this.groupBox_pelanggan.Location = new System.Drawing.Point(13, 13);
            this.groupBox_pelanggan.Name = "groupBox_pelanggan";
            this.groupBox_pelanggan.Size = new System.Drawing.Size(618, 337);
            this.groupBox_pelanggan.TabIndex = 0;
            this.groupBox_pelanggan.TabStop = false;
            this.groupBox_pelanggan.Text = "Data Pelanggan";
            // 
            // dataGridView_pelanggan
            // 
            this.dataGridView_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pelanggan.Location = new System.Drawing.Point(7, 68);
            this.dataGridView_pelanggan.Name = "dataGridView_pelanggan";
            this.dataGridView_pelanggan.Size = new System.Drawing.Size(605, 263);
            this.dataGridView_pelanggan.TabIndex = 2;
            this.dataGridView_pelanggan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pelanggan_CellDoubleClick);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Location = new System.Drawing.Point(204, 33);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(408, 29);
            this.textBox_cari.TabIndex = 1;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Pelanggan (ID/Nama)";
            // 
            // DialogPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 362);
            this.Controls.Add(this.groupBox_pelanggan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Pelanggan";
            this.groupBox_pelanggan.ResumeLayout(false);
            this.groupBox_pelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_pelanggan;
        private System.Windows.Forms.DataGridView dataGridView_pelanggan;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Label label1;
    }
}