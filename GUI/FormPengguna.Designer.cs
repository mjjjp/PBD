namespace Penjualan_PBD_TI14GAB_IndahRPutri.GUI
{
    partial class FormPengguna
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
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_pengguna = new System.Windows.Forms.DataGridView();
            this.button_tambah = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_bersih = new System.Windows.Forms.Button();
            this.groupBox_form.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pengguna)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.comboBox_status);
            this.groupBox_form.Controls.Add(this.textBox_password);
            this.groupBox_form.Controls.Add(this.textBox_username);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(13, 13);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Size = new System.Drawing.Size(260, 240);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = "Form Tambah Pengguna";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Admin",
            "Kasir"});
            this.comboBox_status.Location = new System.Drawing.Point(115, 178);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(139, 29);
            this.comboBox_status.TabIndex = 5;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(115, 83);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(139, 29);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(115, 40);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(139, 29);
            this.textBox_username.TabIndex = 3;
            this.textBox_username.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_pengguna);
            this.groupBox2.Location = new System.Drawing.Point(279, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Pengguna";
            // 
            // dataGridView_pengguna
            // 
            this.dataGridView_pengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pengguna.Location = new System.Drawing.Point(7, 29);
            this.dataGridView_pengguna.Name = "dataGridView_pengguna";
            this.dataGridView_pengguna.Size = new System.Drawing.Size(331, 211);
            this.dataGridView_pengguna.TabIndex = 0;
            // 
            // button_tambah
            // 
            this.button_tambah.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.add32;
            this.button_tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_tambah.Location = new System.Drawing.Point(13, 262);
            this.button_tambah.Name = "button_tambah";
            this.button_tambah.Size = new System.Drawing.Size(134, 43);
            this.button_tambah.TabIndex = 2;
            this.button_tambah.Text = "Tambah";
            this.button_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_tambah.UseVisualStyleBackColor = true;
            // 
            // button_hapus
            // 
            this.button_hapus.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.delete32;
            this.button_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hapus.Location = new System.Drawing.Point(153, 262);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(120, 43);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_hapus.UseVisualStyleBackColor = true;
            // 
            // button_bersih
            // 
            this.button_bersih.Image = global::Penjualan_PBD_TI14GAB_IndahRPutri.Properties.Resources.cancel32;
            this.button_bersih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bersih.Location = new System.Drawing.Point(501, 262);
            this.button_bersih.Name = "button_bersih";
            this.button_bersih.Size = new System.Drawing.Size(122, 43);
            this.button_bersih.TabIndex = 4;
            this.button_bersih.Text = "Bersih";
            this.button_bersih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_bersih.UseVisualStyleBackColor = true;
            // 
            // FormPengguna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 312);
            this.Controls.Add(this.button_bersih);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_tambah);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPengguna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tambah Pengguna";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pengguna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_tambah;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_bersih;
        private System.Windows.Forms.DataGridView dataGridView_pengguna;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
    }
}