namespace AplikasiKonterHP
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public class TopupSaldo
    {
        #region Properties
        public long IdTopupSaldo { get; set; }
        public int IdRekanan { get; set; }
        public string NamaRekanan { get; set; }
        public DateTime TglTopup { get; set; }
        public string JenisTopup { get; set; }
        public int JumlahTopup { get; set; }
        public Int16 Status { get; set; }
        #endregion

        #region Method
        public static int GenerateID()
        {
            return Helpers.GetNewID("TopupSaldo", "IdTopup");
        }

        protected static List<TopupSaldo> myListData(string myQuery)
        {
            List<TopupSaldo> myList = new List<TopupSaldo>();
            using (DataTable myDataTable = DataAccess.ExecuteDataTable(myQuery))
            {
                myList = (from DataRow dr in myDataTable.Rows
                          select new TopupSaldo()
                          {
                              IdTopupSaldo = Convert.ToInt32(dr["IdTopup"]),
                              IdRekanan = Convert.ToInt32(dr["IdRekanan"]),
                              NamaRekanan = dr["NamaRekanan"].ToString(),
                              TglTopup = Convert.ToDateTime(dr["TglTopup"]),
                              JenisTopup = dr["JenisTopup"].ToString(),
                              Status = Convert.ToInt16(dr["Status"])
                          }).ToList();
            }
            return myList;
        }

        public static List<TopupSaldo> GetListTopupSaldo()
        {
            string myQuery = string.Empty;

            myQuery = "Select ts.IdTopup,ts.IdRekanan,rek.NamaRekanan,ts.TglTopup,ts.JenisTopup,ts.JumlahTopup,ts.Status From TopupSaldo as ts" +
                        " inner join rekanan as rek ON rek.IdRekanan = ts.IdRekanan";

            List<TopupSaldo> myList = new List<TopupSaldo>();
            myList = TopupSaldo.myListData(myQuery);
            return myList;
        }

        public static Boolean CreateData(TopupSaldo topupModel,SaldoPulsa saldoModel)
        {
            SaldoPulsa saldoBFC = new SaldoPulsa();
            List<string> sqlList = new List<string>();
            string sqlTopup = "Insert into TopupPulsa(IdTopup,TglTopup,JenisTopup,IdRekanan,jumlahtopup,Status)Values()";

            sqlList.Add(sqlTopup);
            return true;
        }
        #endregion
    }
}
