namespace AplikasiKonterHP
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FrmMasterPulsa : Form
    {
        public FrmMasterPulsa()
        {
            InitializeComponent();
        }

        #region Properties
        void HeaderGrid()
        {
            dgv.Columns[0].HeaderText = "Id Master Pulsa";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].HeaderText = "Id Provider";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].HeaderText = "Kode Master Pulsa";
            dgv.Columns[2].Width = 120;

            dgv.Columns[3].HeaderText = "Keterangan";
            dgv.Columns[3].Width = 100;

            dgv.Columns[4].HeaderText = "Harga";
            dgv.Columns[4].Width = 100;

            dgv.Columns[5].HeaderText = "Nama Provider";
            dgv.Columns[5].Width = 100;

            dgv.Columns[6].HeaderText = "Status Aktif";
            dgv.Columns[6].Width = 100;
        }

        void EnabledInput(bool status)
        {
            cmbProvider.Enabled = status;
            txtKode.Enabled = status;
            txtKeterangan.Enabled = status;
            txtHarga.Enabled = status;
            rdAktif.Enabled = status;
            rdTdkAktif.Enabled = status;
        }

        void ClearInput()
        {
            cmbProvider.Text = "";
            txtKode.Clear();
            txtKeterangan.Clear();
            txtHarga.Clear();
            rdAktif.Checked = false;
            rdTdkAktif.Checked = false;
        }

        void ButtonTambah()
        {
            btnTambah.Enabled = true;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = false;
            btnBatal.Enabled = false;
            btnKeluar.Enabled = true;
        }

        void ButtonSimpan()
        {
            btnTambah.Enabled = false;
            btnEdit.Enabled = false;
            btnSimpan.Enabled = true;
            btnBatal.Enabled = true;
            btnKeluar.Enabled = true;
        }

        void ButtonEdit()
        {
            btnTambah.Enabled = false;
            btnEdit.Enabled = true;
            btnSimpan.Enabled = false;
            btnBatal.Enabled = true;
            btnKeluar.Enabled = true;
        }
        #endregion

        #region Method
        protected int myID;
        protected int statusDisplay;

        MasterPulsa SetData(byte status)
        {
            MasterPulsa myModel = new MasterPulsa();
            switch(status)
            {
                case (1):
                    {
                        myModel.IdMasterPulsa = MasterPulsa.GenerateId();
                        myModel.IdProvider = Convert.ToInt32(cmbProvider.SelectedValue);
                        myModel.KodeMasterPulsa = txtKode.Text;
                        myModel.Keterangan = txtKeterangan.Text;
                        myModel.Harga = Convert.ToInt32(txtHarga.Text);
                        myModel.IsActive = rdAktif.Checked == true ? true : false;
                        break;
                    }
                case (2):
                    {
                        myModel.IdMasterPulsa = myID;
                        myModel.IdProvider = Convert.ToInt32(cmbProvider.SelectedValue);
                        myModel.KodeMasterPulsa = txtKode.Text;
                        myModel.Keterangan = txtKeterangan.Text;
                        myModel.Harga = Convert.ToInt32(txtHarga.Text);
                        myModel.IsActive = rdAktif.Checked == true ? true : false;
                        break;
                    }
            }
            return myModel;
        }

        void ListData()
        {
            dgv.DataSource = MasterPulsa.GetListMasterPulsa(1);
            dgv.ReadOnly = true;
            HeaderGrid();
        }

        void ListDataBySearch()
        {
            dgv.DataSource = MasterPulsa.GetListMasterPulsaByNama(txtCari.Text, cmbCari.Text);
            dgv.ReadOnly = true;
            HeaderGrid();
        }

        void ComboBoxProvider()
        {
            Provider.ComboBoxProvider(cmbProvider);
        }

        void PreCreateDisplay()
        {
            ClearInput();
            EnabledInput(false);
            ButtonTambah();
            ListData();
            myID = 0;
        }
        #endregion

        #region Form
        private void cmbProvider_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void cmbProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKode.Focus();
        }

        private void txtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtKeterangan.Focus();
        }

        private void txtKeterangan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtHarga.Focus();
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                rdAktif.Focus();
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            Helpers.CheckValidationNumber(txtHarga);
        }

        private void cmbCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)0;
        }

        private void cmbCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCari.Focus();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            ListDataBySearch();
        }

        private void FrmMasterPulsa_Load(object sender, EventArgs e)
        {
            PreCreateDisplay();
            this.Text = Helpers.myTitle;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ComboBoxProvider();
            try
            {
                int i = dgv.CurrentRow.Index;
                myID = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);
                cmbProvider.SelectedValue = dgv.Rows[i].Cells[1].Value;
                txtKode.Text = dgv.Rows[i].Cells[2].Value.ToString();
                txtKeterangan.Text = dgv.Rows[i].Cells[3].Value.ToString();
                txtHarga.Text = dgv.Rows[i].Cells[4].Value.ToString();

                if (Convert.ToBoolean(dgv.Rows[i].Cells[6].Value) == true)
                {
                    rdAktif.Checked = true;
                }
                else
                {
                    rdTdkAktif.Checked = true;
                }

                ButtonEdit();
            }
            catch (Exception ex)
            {
                Helpers.MsgBoxError(ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            EnabledInput(true);
            statusDisplay = 1;
            rdAktif.Checked = true;
            ButtonSimpan();
            ComboBoxProvider();
            cmbProvider.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helpers.GetValidate(panel1) == true)
                {
                    if (statusDisplay == 1)
                    {
                        if (MasterPulsa.InsertData(SetData(1)) == true)
                        {
                            Helpers.MsgBoxSave();
                        }
                    }
                    else if (statusDisplay == 2)
                    {
                        if (MasterPulsa.UpdateDate(SetData(2)) == true)
                        {
                            Helpers.MsgBoxSave();
                        }
                    }
                    PreCreateDisplay();
                }

            }
            catch (Exception ex)
            {
                Helpers.MsgBoxError(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnabledInput(true);
            statusDisplay = 2;
            ButtonSimpan();
            cmbProvider.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            PreCreateDisplay();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
