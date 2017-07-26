namespace AplikasiKonterHP
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public class Rekanan
    {
        #region Properties
        public int IdRekanan { get; set; }
        public char TipeRekanan { get; set; }
        public string TipeRekananDesc { get; set; }
        public string NamaRekanan { get; set; }
        public string Alamat { get; set; }
        public string NoTlp { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Method
        public static int GenerateId()
        {
            return Helpers.GetNewID("Rekanan", "IdRekanan");
        }

        public static List<Rekanan> GetListRekanan(byte StatusOptions)
        {
            // status options
            // 1.semua data,2. hanya data yg aktif
            string myQuery = string.Empty;

            switch (StatusOptions)
            {
                case (1):
                    {
                        myQuery = "Select IdRekanan,TipeRekanan,Case when TipeRekanan = 'S' THEN 'Supplier' ELSE 'Pelanggan' END AS TipeRekananDesc,NamaRekanan" +
                                    ",Alamat,NoTlp,IsActive From Rekanan";
                    }
                    break;

                case (2):
                    {
                        myQuery = "Select IdRekanan,TipeRekanan,Case when TipeRekanan = 'S' THEN 'Supplier' ELSE 'Pelanggan' END AS TipeRekananDesc,NamaRekanan" +
                                    ",Alamat,NoTlp,IsActive From Rekanan Where IsActive = 1";
                    }
                    break;
            }

            List<Rekanan> myList = new List<Rekanan>();
            using (DataTable myDataTable = DataAccess.ExecuteDataTable(myQuery))
            {
                myList = (from DataRow dr in myDataTable.Rows
                                  select new Rekanan()
                                  {
                                      IdRekanan = Convert.ToInt32(dr["IdRekanan"]),
                                      TipeRekanan = Convert.ToChar(dr["TipeRekanan"]),
                                      TipeRekananDesc = dr["TipeRekananDesc"].ToString(),
                                      NamaRekanan = dr["NamaRekanan"].ToString(),
                                      Alamat = dr["Alamat"].ToString(),
                                      NoTlp = dr["NoTlp"].ToString(),
                                      IsActive = Convert.ToBoolean(dr["IsActive"])
                                  }).ToList();
            }
            return myList;
        }

        public static List<Rekanan> GetListRekananByNama(string searchNama,string statusOptions)
        {
            string myQuery = string.Empty;

            switch (statusOptions)
            {
                case ("Nama Rekanan"):
                    {
                        myQuery = "Select IdRekanan,TipeRekanan,Case when TipeRekanan = 'S' THEN 'Supplier' ELSE 'Pelanggan' END TipeRekananDesc,NamaRekanan" +
                                    ",Alamat,NoTlp,IsActive From Rekanan Where NamaRekanan LIKE '%" + searchNama + "%'";
                    }
                    break;

                case ("Alamat"):
                    {
                        myQuery = "Select IdRekanan,TipeRekanan,Case when TipeRekanan = 'S' THEN 'Supplier' ELSE 'Pelanggan' END TipeRekananDesc,NamaRekanan" +
                                    ",Alamat,NoTlp,IsActive From Rekanan Where Alamat LIKE '%" + searchNama + "%'";
                    }
                    break;
            }

            List<Rekanan> myList = new List<Rekanan>();
            using (DataTable myDataTable = DataAccess.ExecuteDataTable(myQuery))
            {
                myList = (from DataRow dr in myDataTable.Rows
                          select new Rekanan()
                          {
                              IdRekanan = Convert.ToInt32(dr["IdRekanan"]),
                              TipeRekanan = Convert.ToChar(dr["TipeRekanan"]),
                              TipeRekananDesc = dr["TipeRekananDesc"].ToString(),
                              NamaRekanan = dr["NamaRekanan"].ToString(),
                              Alamat = dr["Alamat"].ToString(),
                              NoTlp = dr["NoTlp"].ToString(),
                              IsActive = Convert.ToBoolean(dr["IsActive"])
                          }).ToList();
            }
            return myList;
        }

        public static void ComboBoxAllRekanan(ComboBox cmb)
        {
            cmb.DataSource = GetListRekanan(2);
            cmb.ValueMember = "IdRekanan";
            cmb.DisplayMember = "NamaRekanan";
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        
        public static Boolean InsertData(Rekanan rekanan)
        {
            string sql = "Insert into Rekanan values('" + rekanan.IdRekanan + "','" + rekanan.TipeRekanan + "','" + rekanan.NamaRekanan + "'" +
                            ",'" + rekanan.Alamat + "','" + rekanan.NoTlp + "','" + rekanan.IsActive + "')";
            try
            {
                DataAccess.ExecuteNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }


        public static Boolean UpdateDate(Rekanan rekanan)
        {
            string sql = "Update Rekanan set TipeRekanan = '" + rekanan.TipeRekanan + "',NamaRekanan = '" + rekanan.NamaRekanan + "'" +
                            ",Alamat = '" + rekanan.Alamat + "',NoTlp = '" + rekanan.NoTlp + "',IsActive = " + rekanan.IsActive
                            + " Where IdRekanan= " + rekanan.IdRekanan + "";
            try
            {
                DataAccess.ExecuteNonQuery(sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        #endregion
    }
}
