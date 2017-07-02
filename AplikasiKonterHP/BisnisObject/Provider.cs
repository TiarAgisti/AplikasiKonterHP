namespace AplikasiKonterHP
{
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Provider
    {
        #region Properties
        public int IdProvider { get; set; }
        public string NamaProvider { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Method
        public static int GenerateIdProvider()
        {
            return Helpers.GetNewID("Provider", "IdProvider");
        }

        public static List<Provider>GetListProvider(byte StatusOptions)
        {
            // status options
            // 1.semua provider,2. hanya provider yg aktif
            string myQuery = string.Empty;

            switch(StatusOptions)
            {
                case (1):
                    {
                        myQuery = "Select * From Provider";
                    }
                    break;

                case (2):
                    {
                        myQuery = "Select * From Provider where IsActive = 1";
                    }
                    break;
            }

            List<Provider> myListProvider = new List<Provider>();
            using (DataTable myDataTable = DataAccess.ExecuteDataTable(myQuery))
            {
                myListProvider = (from DataRow dr in myDataTable.Rows
                                  select new Provider()
                                  {
                                      IdProvider = Convert.ToInt32(dr["IdProvider"]),
                                      NamaProvider = dr["NamaProvider"].ToString(),
                                      IsActive = Convert.ToBoolean(dr["IsActive"])
                                  }).ToList();
            }
            return myListProvider;
        }

        public static List<Provider>GetListProviderByNama(string searchNama)
        {
            string myQuery = "Select * From Provider Where NamaProvider LIKE '%" + searchNama + "%'";
            List<Provider> myList = new List<Provider>();
            using (DataTable myDataTable = DataAccess.ExecuteDataTable(myQuery))
            {
                myList = (from DataRow dr in myDataTable.Rows
                                  select new Provider()
                                  {
                                      IdProvider = Convert.ToInt32(dr["IdProvider"]),
                                      NamaProvider = dr["NamaProvider"].ToString(),
                                      IsActive = Convert.ToBoolean(dr["IsActive"])
                                  }).ToList();
            }
            return myList;
        }

        public static Boolean InsertData(Provider provider)
        {
            string sql = "Insert into Provider values('" + provider.IdProvider + "','" + provider.NamaProvider + "','" + provider.IsActive + "')";
            try
            {
                DataAccess.ExecuteNonQuery(sql);
                return true;
            }
            catch(Exception ex)
            {
                return false;
                throw ex;  
            }
        }

        public static Boolean UpdateDate(Provider provider)
        {
            string sql = "Update Provider set NamaProvider = '" + provider.NamaProvider + "',IsActive = " + provider.IsActive 
                            + " Where IdProvider = " + provider.IdProvider + "";
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
