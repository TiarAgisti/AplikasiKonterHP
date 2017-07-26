namespace AplikasiKonterHP
{
    partial class FrmTopupPulsa
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
            this.cmbNama = new System.Windows.Forms.ComboBox();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTgl = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Topup Pulsa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbNama);
            this.panel1.Controls.Add(this.cmbJenis);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtJumlah);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpTgl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 131);
            this.panel1.TabIndex = 4;
            // 
            // cmbNama
            // 
            this.cmbNama.FormattingEnabled = true;
            this.cmbNama.Items.AddRange(new object[] {
            "Topup",
            "Transfer"});
            this.cmbNama.Location = new System.Drawing.Point(91, 62);
            this.cmbNama.Name = "cmbNama";
            this.cmbNama.Size = new System.Drawing.Size(200, 21);
            this.cmbNama.TabIndex = 11;
            this.cmbNama.SelectedIndexChanged += new System.EventHandler(this.cmbNama_SelectedIndexChanged);
            this.cmbNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNama_KeyPress);
            // 
            // cmbJenis
            // 
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Items.AddRange(new object[] {
            "Topup",
            "Transfer"});
            this.cmbJenis.Location = new System.Drawing.Point(91, 35);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(200, 21);
            this.cmbJenis.TabIndex = 10;
            this.cmbJenis.SelectedIndexChanged += new System.EventHandler(this.cmbJenis_SelectedIndexChanged);
            this.cmbJenis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbJenis_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenis Topup";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(91, 89);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(200, 20);
            this.txtJumlah.TabIndex = 6;
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Rekanan";
            // 
            // dtpTgl
            // 
            this.dtpTgl.Location = new System.Drawing.Point(91, 9);
            this.dtpTgl.Name = "dtpTgl";
            this.dtpTgl.Size = new System.Drawing.Size(200, 20);
            this.dtpTgl.TabIndex = 1;
            this.dtpTgl.ValueChanged += new System.EventHandler(this.dtpTgl_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tgl Topup";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Controls.Add(this.btnHapus);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 35);
            this.panel2.TabIndex = 5;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(167, 4);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 6;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(86, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 4;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(5, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FrmTopupPulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 212);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTopupPulsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTopupPulsa";
            this.Load += new System.EventHandler(this.FrmTopupPulsa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTgl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNama;
    }
}