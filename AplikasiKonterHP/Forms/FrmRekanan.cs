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

    public partial class FrmRekanan : Form
    {
        public FrmRekanan()
        {
            InitializeComponent();
        }

        #region Properties
        void HeaderGrid()
        {
            dgv.Columns[0].HeaderText = "Id Rekanan";
            dgv.Columns[0].Visible = false;

            dgv.Columns[1].HeaderText = "Tipe Rekanan";
            dgv.Columns[1].Visible = false;

            dgv.Columns[2].HeaderText = "Tipe Rekanan";
            dgv.Columns[2].Width = 100;

            dgv.Columns[3].HeaderText = "Nama Rekanan";
            dgv.Columns[3].Width = 130;

            dgv.Columns[4].HeaderText = "Alamat";
            dgv.Columns[4].Width = 150;

            dgv.Columns[5].HeaderText = "No Telp";

            dgv.Columns[6].HeaderText = "Status Aktif";
        }

        void EnabledInput(bool status)
        {
            cmbTipe.Enabled = status;
            txtNama.Enabled = status;
            txtAlamat.Enabled = status;
            txtTlp.Enabled = status;
            rdAktif.Enabled = status;
            rdTdkAktif.Enabled = status;
        }

        void ClearInput()
        {
            cmbTipe.Text = "";
            txtNama.Clear();
            txtAlamat.Clear();
            txtTlp.Clear();
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
        int myID;
        int statusDisplay; //1 for create,2 for edit

        Rekanan SetData(byte status)
        {
            //1 for create,2 for edit
            Rekanan myData = new Rekanan();
            switch (status)
            {
                case (1):
                    {
                        myData.IdRekanan = Rekanan.GenerateId();
                        myData.TipeRekanan = cmbTipe.Text == "Supplier" ? Convert.ToChar("S") : Convert.ToChar("P");
                        myData.NamaRekanan = txtNama.Text;
                        myData.Alamat = txtAlamat.Text;
                        myData.NoTlp = txtTlp.Text;
                        if (rdAktif.Checked == true)
                        {
                            myData.IsActive = true;
                        }
                        if (rdTdkAktif.Checked == true)
                        {
                            myData.IsActive = false;
                        }
                    }
                    break;

                case (2):
                    {
                        myData.IdRekanan = myID;
                        myData.TipeRekanan = cmbTipe.Text == "Supplier" ? Convert.ToChar("S") : Convert.ToChar("P");
                        myData.NamaRekanan = txtNama.Text;
                        myData.Alamat = txtAlamat.Text;
                        myData.NoTlp = txtTlp.Text;
                        if (rdAktif.Checked == true)
                        {
                            myData.IsActive = true;
                        }
                        if (rdTdkAktif.Checked == true)
                        {
                            myData.IsActive = false;
                        }
                    }
                    break;
            }
            return myData;
        }

        void ListData()
        {
            dgv.DataSource = Rekanan.GetListRekanan(1);
            dgv.ReadOnly = true;
            HeaderGrid();
        }

        void ListDataBySearch()
        {
            dgv.DataSource = Rekanan.GetListRekananByNama(txtCari.Text,cmbCari.Text);
            dgv.ReadOnly = true;
            HeaderGrid();
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
        private void cmbTipe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtNama.Focus();
            else
                e.KeyChar = (char)0;
        }

        private void cmbTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNama.Focus();
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtAlamat.Focus();
        }

        private void txtAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtTlp.Focus();
        }

        private void txtTlp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                rdAktif.Focus();
        }

        private void txtTlp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTlp.Text))
            {
                txtTlp.Text = "";
            }
            else
            {
                Helpers.CheckValidationNumber(txtTlp);
            }
        }

        private void FrmRekanan_Load(object sender, EventArgs e)
        {
            PreCreateDisplay();
            this.Text = Helpers.myTitle;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            EnabledInput(true);
            statusDisplay = 1;
            rdAktif.Checked = true;
            ButtonSimpan();
            cmbTipe.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helpers.GetValidate(panel1) == true)
                {
                    if (statusDisplay == 1)
                    {
                        if (Rekanan.InsertData(SetData(1)) == true)
                        {
                            Helpers.MsgBoxSave();
                        }
                    }
                    else if (statusDisplay == 2)
                    {
                        if (Rekanan.UpdateDate(SetData(2)) == true)
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
            cmbTipe.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            try
            {
                PreCreateDisplay();
            }
            catch (Exception ex)
            {
                Helpers.MsgBoxError(ex.Message);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dgv.CurrentRow.Index;
                myID = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);
                cmbTipe.Text = dgv.Rows[i].Cells[2].Value.ToString();
                txtNama.Text = dgv.Rows[i].Cells[3].Value.ToString();
                txtAlamat.Text = dgv.Rows[i].Cells[4].Value.ToString();
                txtTlp.Text = dgv.Rows[i].Cells[5].Value.ToString();

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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            ListDataBySearch();
        }
        #endregion
    }
}
