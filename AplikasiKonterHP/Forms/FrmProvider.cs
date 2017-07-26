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

    public partial class FrmProvider : Form
    {
        public FrmProvider()
        {
            InitializeComponent();
        }

        #region Properties
        void HeaderGrid()
        {
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].HeaderText = "Provider";
            dgv.Columns[2].HeaderText = "Status Aktif";
        }

        void EnabledInput(bool status)
        {
            txtProvider.Enabled = status;
            rdAktif.Enabled = status;
            rdTdkAktif.Enabled = status;
        }

        void ClearInput()
        {
            txtProvider.Clear();
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
        Provider SetData(byte status)
        {
            Provider myData = new Provider();
            switch (status)
            {
                case (1):
                    {
                        myData.IdProvider = Provider.GenerateIdProvider();
                        myData.NamaProvider = txtProvider.Text;
                        if (rdAktif.Checked == true)
                        {
                            myData.IsActive = true;
                        }
                        if(rdTdkAktif.Checked == true)
                        {
                            myData.IsActive = false;
                        }
                    }
                    break;

                case (2):
                    {
                        myData.IdProvider = myID;
                        myData.NamaProvider = txtProvider.Text;
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
            dgv.DataSource = Provider.GetListProvider(1);
            dgv.ReadOnly = true;
            HeaderGrid();
        }

        void ListDataByProvider()
        {
            dgv.DataSource = Provider.GetListProviderByNama(txtCari.Text);
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
            txtProvider.Focus();
        }
        #endregion

        private void FrmProvider_Load(object sender, EventArgs e)
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
            txtProvider.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helpers.GetValidate(panel1) == true)
                {
                    if (statusDisplay == 1)
                    {
                        if (Provider.InsertData(SetData(1)) == true)
                        {
                            Helpers.MsgBoxSave();
                        }
                    }
                    else if (statusDisplay == 2)
                    {
                        if (Provider.UpdateDate(SetData(2)) == true)
                        {
                            Helpers.MsgBoxSave();
                        }
                    }
                    PreCreateDisplay();
                }
                
            }
            catch(Exception ex)
            {
                Helpers.MsgBoxError(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnabledInput(true);
            statusDisplay = 2;
            ButtonSimpan();
            txtProvider.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            try
            {
                PreCreateDisplay();
            }
            catch(Exception ex)
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
                txtProvider.Text = dgv.Rows[i].Cells[1].Value.ToString();

                if (Convert.ToBoolean(dgv.Rows[i].Cells[2].Value) == true)
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
            ListDataByProvider();
        }
    }
}
