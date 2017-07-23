namespace AplikasiKonterHP
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MasterPulsa
    {
        #region Properties
        public int IdMasterPulsa { get; set; }
        public int IdProvider { get; set; }
        public string KodeMasterPulsa { get; set; }
        public string Keterangan { get; set; }
        public int Harga { get; set; }
        public string NamaProvider { get; set; }
        public bool IsActive { get; set; }

        
        #endregion

        #region Method
        public static int GenerateId()
        {
            return Helpers.GetNewID("MasterPulsa", "IdMasterPulsa");
        }

        public static List<MasterPulsa> GetListMasterPulsa(byte StatusOptions)
        {
            // status options
            // 1.semua data,2. hanya data yg aktif
            string myQuery = string.Empty;

            switch (StatusOptions)
            {
                case (1):
                    {
                        myQuery = "Select pvd.NamaProvider,mp.* From masterpulsa as mp inner join provider as pvd on pvd.IdProvider = mp.IdProvider";
                    }
                    break;

                case (2):
                    {
                        myQuery = "Select pvd.NamaProvider,mp.* From masterpulsa as mp inner join provider as pvd on pvd.IdProvider = mp.IdProvider" +
                                    " Where mp.IsActive = 1";
                    }
                    break;
            }

            List<MasterPulsa> myList = new List<MasterPulsa>();
            using (DataTable myDataTable = DataAccess.ExecuteDataTable(myQuery))
            {
                myList = (from DataRow dr in myDataTable.Rows
                          select new MasterPulsa()
                          {
                              IdMasterPulsa = Convert.ToInt32(dr["IdMasterPulsa"]),
                              IdProvider = Convert.ToChar(dr["IdProvider"]),
                              KodeMasterPulsa = dr["KodeMasterPulsa"].ToString(),
                              Keterangan = dr["Keterangan"].ToString(),
                              Harga = Convert.ToInt32(dr["Harga"]),
                              NamaProvider = dr["NamaProvider"].ToString(),
                              IsActive = Convert.ToBoolean(dr["IsActive"])
                          }).ToList();
            }
            return myList;
        }

        public static List<MasterPulsa> GetListMasterPulsaByNama(string searchNama, string statusOptions)
        {
            string myQuery = string.Empty;

            switch (statusOptions)
            {
                case ("Provider"):
                    {
                        myQuery = "Select pvd.NamaProvider,mp.* From masterpulsa as mp inner join provider as pvd on pvd.IdProvider = mp.IdProvider" +
                                    " Where pvd.NamaProvider LIKE '%" + searchNama + "%'";
                    }
                    break;

                case ("Kode Master Pulsa"):
                    {
                        myQuery = "Select pvd.NamaProvider,mp.* From masterpulsa as mp inner join provider as pvd on pvd.IdProvider = mp.IdProvider" +
                                    " Where mp.KodeMasterPulsa LIKE '%" + searchNama + "%'";
                    }
                    break;
            }

            List<MasterPulsa> myList = new List<MasterPulsa>();
            using (DataTable myDataTable = DataAccess.ExecuteDataTable(myQuery))
            {
                myList = (from DataRow dr in myDataTable.Rows
                          select new MasterPulsa()
                          {
                              IdMasterPulsa = Convert.ToInt32(dr["IdMasterPulsa"]),
                              IdProvider = Convert.ToChar(dr["IdProvider"]),
                              KodeMasterPulsa = dr["KodeMasterPulsa"].ToString(),
                              Keterangan = dr["Keterangan"].ToString(),
                              Harga = Convert.ToInt32(dr["Harga"]),
                              NamaProvider = dr["NamaProvider"].ToString(),
                              IsActive = Convert.ToBoolean(dr["IsActive"])
                          }).ToList();
            }
            return myList;
        }

        public static Boolean InsertData(MasterPulsa masterPulsa)
        {
            string sql = "Insert into MasterPulsa values('" + masterPulsa.IdMasterPulsa + "','" + masterPulsa.IdProvider + "','" + masterPulsa.KodeMasterPulsa + "'" +
                            ",'" + masterPulsa.Keterangan + "','" + masterPulsa.Harga + "','" + masterPulsa.IsActive + "')";
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

        public static Boolean UpdateDate(MasterPulsa masterPulsa)
        {
            string sql = "Update MasterPulsa set IdProvider = '" + masterPulsa.IdProvider + "',KodeMasterPulsa = '" + masterPulsa.KodeMasterPulsa + "'" +
                            ",Keterangan = '" + masterPulsa.Keterangan + "',Harga = '" + masterPulsa.Harga + "',IsActive = " + masterPulsa.IsActive
                            + " Where IdMasterPulsa= " + masterPulsa.IdProvider + "";
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
