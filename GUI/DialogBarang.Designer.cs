namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    partial class DialogBarang
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
            this.groupBox_barang = new System.Windows.Forms.GroupBox();
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_barang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_barang
            // 
            this.groupBox_barang.Controls.Add(this.dataGridView_barang);
            this.groupBox_barang.Controls.Add(this.textBox_cari);
            this.groupBox_barang.Controls.Add(this.label1);
            this.groupBox_barang.Location = new System.Drawing.Point(12, 12);
            this.groupBox_barang.Name = "groupBox_barang";
            this.groupBox_barang.Size = new System.Drawing.Size(597, 320);
            this.groupBox_barang.TabIndex = 0;
            this.groupBox_barang.TabStop = false;
            this.groupBox_barang.Text = "Data Barang";
            // 
            // dataGridView_barang
            // 
            this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barang.Location = new System.Drawing.Point(9, 66);
            this.dataGridView_barang.Name = "dataGridView_barang";
            this.dataGridView_barang.Size = new System.Drawing.Size(581, 247);
            this.dataGridView_barang.TabIndex = 2;
            this.dataGridView_barang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellDoubleClick);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Location = new System.Drawing.Point(199, 26);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(391, 29);
            this.textBox_cari.TabIndex = 1;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Barang (Kode/Nama)";
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 344);
            this.Controls.Add(this.groupBox_barang);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Barang";
            this.groupBox_barang.ResumeLayout(false);
            this.groupBox_barang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_barang;
        private System.Windows.Forms.DataGridView dataGridView_barang;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Label label1;
    }
}