namespace AplikasiKonterHP
{
    partial class FrmRekanan
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
            this.txtTlp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdTdkAktif = new System.Windows.Forms.RadioButton();
            this.rdAktif = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(619, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rekanan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTlp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAlamat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rdTdkAktif);
            this.panel1.Controls.Add(this.rdAktif);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNama);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTipe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 159);
            this.panel1.TabIndex = 3;
            // 
            // txtTlp
            // 
            this.txtTlp.Location = new System.Drawing.Point(85, 97);
            this.txtTlp.Name = "txtTlp";
            this.txtTlp.Size = new System.Drawing.Size(213, 20);
            this.txtTlp.TabIndex = 4;
            this.txtTlp.Tag = "1;Telp,1,0-,0-";
            this.txtTlp.TextChanged += new System.EventHandler(this.txtTlp_TextChanged);
            this.txtTlp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTlp_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telp";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(85, 71);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(483, 20);
            this.txtAlamat.TabIndex = 3;
            this.txtAlamat.Tag = "1;Alamat,1,0-,0-";
            this.txtAlamat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlamat_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alamat";
            // 
            // rdTdkAktif
            // 
            this.rdTdkAktif.AutoSize = true;
            this.rdTdkAktif.Location = new System.Drawing.Point(137, 123);
            this.rdTdkAktif.Name = "rdTdkAktif";
            this.rdTdkAktif.Size = new System.Drawing.Size(76, 17);
            this.rdTdkAktif.TabIndex = 6;
            this.rdTdkAktif.TabStop = true;
            this.rdTdkAktif.Text = "Tidak Aktif";
            this.rdTdkAktif.UseVisualStyleBackColor = true;
            // 
            // rdAktif
            // 
            this.rdAktif.AutoSize = true;
            this.rdAktif.Location = new System.Drawing.Point(85, 123);
            this.rdAktif.Name = "rdAktif";
            this.rdAktif.Size = new System.Drawing.Size(46, 17);
            this.rdAktif.TabIndex = 5;
            this.rdAktif.TabStop = true;
            this.rdAktif.Text = "Aktif";
            this.rdAktif.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(85, 45);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(483, 20);
            this.txtNama.TabIndex = 2;
            this.txtNama.Tag = "1;Alamat,1,0-,0-";
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama";
            // 
            // cmbTipe
            // 
            this.cmbTipe.FormattingEnabled = true;
            this.cmbTipe.Items.AddRange(new object[] {
            "Supplier",
            "Pelanggan"});
            this.cmbTipe.Location = new System.Drawing.Point(85, 18);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(213, 21);
            this.cmbTipe.TabIndex = 1;
            this.cmbTipe.Tag = "1;Tipe Rekanan,1,0-,0-";
            this.cmbTipe.SelectedIndexChanged += new System.EventHandler(this.cmbTipe_SelectedIndexChanged);
            this.cmbTipe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipe_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipe Rekanan";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Controls.Add(this.btnBatal);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnTambah);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 40);
            this.panel2.TabIndex = 4;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(334, 4);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 11;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(253, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 10;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(172, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 9;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(91, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(10, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.cmbCari);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Data";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(231, 19);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(338, 20);
            this.txtCari.TabIndex = 13;
            this.txtCari.Tag = "1;Provider,1,0-,0-";
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // cmbCari
            // 
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Items.AddRange(new object[] {
            "Nama",
            "Alamat"});
            this.cmbCari.Location = new System.Drawing.Point(12, 19);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(213, 21);
            this.cmbCari.TabIndex = 12;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 300);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(619, 252);
            this.dgv.TabIndex = 14;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // FrmRekanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 552);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRekanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRekanan";
            this.Load += new System.EventHandler(this.FrmRekanan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdTdkAktif;
        private System.Windows.Forms.RadioButton rdAktif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTlp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbCari;
        private System.Windows.Forms.DataGridView dgv;
    }
}