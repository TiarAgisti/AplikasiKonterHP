namespace AplikasiKonterHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    //using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FrmListTopupPulsa : Form
    {
        public FrmListTopupPulsa()
        {
            InitializeComponent();
        }

        #region Properties
        void HeaderGrid()
        {
            dgv.Columns[0].HeaderText = "Id Topup";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].HeaderText = "Id Rekanan";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].HeaderText = "Nama Rekanan";
            dgv.Columns[2].Width = 150;

            dgv.Columns[3].HeaderText = "Tgl Topup";
            dgv.Columns[3].Width = 120;

            dgv.Columns[4].HeaderText = "Jenis Topup";
            dgv.Columns[4].Width = 120;

            dgv.Columns[5].HeaderText = "Jumlah Topup";
            dgv.Columns[5].Width = 150;

            dgv.Columns[6].HeaderText = "Status";
            dgv.Columns[6].Visible = false;
        }
        #endregion

        #region Method
        void ListData()
        {
            dgv.DataSource = TopupSaldo.GetListTopupSaldo();
            dgv.ReadOnly = true;
            HeaderGrid();
        }

        void ClearFilter()
        {
            chkTopup.Checked = false;
            chkJenis.Checked = false;
            chkNama.Checked = false;
            dtpTglTopup.Value = DateTime.Now;
            cmbJenisTopup.Text = string.Empty;
            txtNamaRekanan.Clear();
        }

        void PreCreateDisplay()
        {
            ClearFilter();
            ListData();
        }


        #endregion

        #region Form
        private void FrmListTopupPulsa_Load(object sender, EventArgs e)
        {
            PreCreateDisplay();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnLihat_Click(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
