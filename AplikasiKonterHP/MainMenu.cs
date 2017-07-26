using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKonterHP
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void menuProvider_Click(object sender, EventArgs e)
        {
            FrmProvider frm = new FrmProvider();
            frm.Show();
        }

        private void menuRekanan_Click(object sender, EventArgs e)
        {
            FrmRekanan frm = new FrmRekanan();
            frm.Show();
        }

        private void menuKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuMasterPulsa_Click(object sender, EventArgs e)
        {
            FrmMasterPulsa frm = new FrmMasterPulsa();
            frm.Show();
        }

        private void menuTopupSaldo_Click(object sender, EventArgs e)
        {
            FrmListTopupPulsa frm = new FrmListTopupPulsa();
            frm.Show();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
