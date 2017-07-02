using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
