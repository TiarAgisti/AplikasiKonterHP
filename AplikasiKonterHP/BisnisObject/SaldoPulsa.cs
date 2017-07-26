namespace AplikasiKonterHP
{
    public class SaldoPulsa
    {
        #region Properties
        public long IdSaldo { get; set; }
        public long IdTopup { get; set; }
        public int Saldo { get; set; }
        #endregion

        #region Method
        public static int GenerateId()
        {
            return Helpers.GetNewID("SaldoPulsa", "IdSaldo");
        }

        public string InsertData(SaldoPulsa saldoPulsaModel)
        {
            string sql;
            sql = "Insert into SaldoPulsa(IdSaldo,IdTopup,Saldo)Values" +
                    "('" + saldoPulsaModel.IdSaldo + "','" + saldoPulsaModel.IdTopup + "','" + saldoPulsaModel.Saldo + "')";
            return sql;
        }

        public string UpdateData(SaldoPulsa saldoPulsaModel)
        {
            string sql;
            sql = "Update SaldoPulsa set Saldo = '" + saldoPulsaModel.Saldo + "' Where IdSaldo = '" + saldoPulsaModel.IdSaldo + "'";
            return sql;
        }
        #endregion
    }
}
