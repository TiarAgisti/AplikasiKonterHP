namespace AplikasiKonterHP
{
    partial class FrmListTopupPulsa
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbJenisTopup = new System.Windows.Forms.ComboBox();
            this.chkJenis = new System.Windows.Forms.CheckBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtNamaRekanan = new System.Windows.Forms.TextBox();
            this.chkNama = new System.Windows.Forms.CheckBox();
            this.dtpTglTopup = new System.Windows.Forms.DateTimePicker();
            this.chkTopup = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Topup Pulsa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbJenisTopup);
            this.panel1.Controls.Add(this.chkJenis);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.btnCari);
            this.panel1.Controls.Add(this.txtNamaRekanan);
            this.panel1.Controls.Add(this.chkNama);
            this.panel1.Controls.Add(this.dtpTglTopup);
            this.panel1.Controls.Add(this.chkTopup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 122);
            this.panel1.TabIndex = 3;
            // 
            // cmbJenisTopup
            // 
            this.cmbJenisTopup.FormattingEnabled = true;
            this.cmbJenisTopup.Location = new System.Drawing.Point(118, 35);
            this.cmbJenisTopup.Name = "cmbJenisTopup";
            this.cmbJenisTopup.Size = new System.Drawing.Size(200, 21);
            this.cmbJenisTopup.TabIndex = 11;
            // 
            // chkJenis
            // 
            this.chkJenis.AutoSize = true;
            this.chkJenis.Location = new System.Drawing.Point(11, 37);
            this.chkJenis.Name = "chkJenis";
            this.chkJenis.Size = new System.Drawing.Size(84, 17);
            this.chkJenis.TabIndex = 6;
            this.chkJenis.Text = "Jenis Topup";
            this.chkJenis.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(199, 90);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(118, 90);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 4;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtNamaRekanan
            // 
            this.txtNamaRekanan.Location = new System.Drawing.Point(118, 62);
            this.txtNamaRekanan.Name = "txtNamaRekanan";
            this.txtNamaRekanan.Size = new System.Drawing.Size(346, 20);
            this.txtNamaRekanan.TabIndex = 3;
            // 
            // chkNama
            // 
            this.chkNama.AutoSize = true;
            this.chkNama.Location = new System.Drawing.Point(11, 64);
            this.chkNama.Name = "chkNama";
            this.chkNama.Size = new System.Drawing.Size(101, 17);
            this.chkNama.TabIndex = 2;
            this.chkNama.Text = "Nama Rekanan";
            this.chkNama.UseVisualStyleBackColor = true;
            // 
            // dtpTglTopup
            // 
            this.dtpTglTopup.Location = new System.Drawing.Point(118, 9);
            this.dtpTglTopup.Name = "dtpTglTopup";
            this.dtpTglTopup.Size = new System.Drawing.Size(200, 20);
            this.dtpTglTopup.TabIndex = 1;
            // 
            // chkTopup
            // 
            this.chkTopup.AutoSize = true;
            this.chkTopup.Location = new System.Drawing.Point(11, 12);
            this.chkTopup.Name = "chkTopup";
            this.chkTopup.Size = new System.Drawing.Size(75, 17);
            this.chkTopup.TabIndex = 0;
            this.chkTopup.Text = "Tgl Topup";
            this.chkTopup.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Controls.Add(this.btnLihat);
            this.panel2.Controls.Add(this.btnTambah);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 56);
            this.panel2.TabIndex = 4;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(172, 16);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 7;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.Location = new System.Drawing.Point(91, 16);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(75, 23);
            this.btnLihat.TabIndex = 7;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.UseVisualStyleBackColor = true;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(10, 16);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 6;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 224);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(772, 319);
            this.dgv.TabIndex = 5;
            // 
            // FrmListTopupPulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 543);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListTopupPulsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListTopupPulsa";
            this.Load += new System.EventHandler(this.FrmListTopupPulsa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtNamaRekanan;
        private System.Windows.Forms.CheckBox chkNama;
        private System.Windows.Forms.DateTimePicker dtpTglTopup;
        private System.Windows.Forms.CheckBox chkTopup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnLihat;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.CheckBox chkJenis;
        private System.Windows.Forms.ComboBox cmbJenisTopup;
    }
}