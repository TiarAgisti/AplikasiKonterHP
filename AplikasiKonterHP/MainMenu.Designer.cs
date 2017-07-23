namespace AplikasiKonterHP
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRekanan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMasterPulsa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeluar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMaster,
            this.menuTransaksi,
            this.menuKeluar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMaster
            // 
            this.menuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProvider,
            this.menuRekanan,
            this.menuMasterPulsa});
            this.menuMaster.Name = "menuMaster";
            this.menuMaster.Size = new System.Drawing.Size(55, 20);
            this.menuMaster.Text = "Master";
            // 
            // menuProvider
            // 
            this.menuProvider.Name = "menuProvider";
            this.menuProvider.Size = new System.Drawing.Size(141, 22);
            this.menuProvider.Text = "Provider";
            this.menuProvider.Click += new System.EventHandler(this.menuProvider_Click);
            // 
            // menuRekanan
            // 
            this.menuRekanan.Name = "menuRekanan";
            this.menuRekanan.Size = new System.Drawing.Size(141, 22);
            this.menuRekanan.Text = "Rekanan";
            this.menuRekanan.Click += new System.EventHandler(this.menuRekanan_Click);
            // 
            // menuMasterPulsa
            // 
            this.menuMasterPulsa.Name = "menuMasterPulsa";
            this.menuMasterPulsa.Size = new System.Drawing.Size(152, 22);
            this.menuMasterPulsa.Text = "Master Pulsa";
            this.menuMasterPulsa.Click += new System.EventHandler(this.menuMasterPulsa_Click);
            // 
            // menuTransaksi
            // 
            this.menuTransaksi.Name = "menuTransaksi";
            this.menuTransaksi.Size = new System.Drawing.Size(67, 20);
            this.menuTransaksi.Text = "Transaksi";
            // 
            // menuKeluar
            // 
            this.menuKeluar.Name = "menuKeluar";
            this.menuKeluar.Size = new System.Drawing.Size(52, 20);
            this.menuKeluar.Text = "Keluar";
            this.menuKeluar.Click += new System.EventHandler(this.menuKeluar_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 475);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMaster;
        private System.Windows.Forms.ToolStripMenuItem menuProvider;
        private System.Windows.Forms.ToolStripMenuItem menuRekanan;
        private System.Windows.Forms.ToolStripMenuItem menuMasterPulsa;
        private System.Windows.Forms.ToolStripMenuItem menuTransaksi;
        private System.Windows.Forms.ToolStripMenuItem menuKeluar;
    }
}

