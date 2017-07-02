namespace AplikasiKonterHP
{
    using System;
    using System.Data;
    using MySql.Data;
    using System.Collections.Generic;
    using MySql.Data.MySqlClient;
    using System.Windows.Forms;
    using System.IO;
    using Properties;

    public class DataAccess
    {
        public DataAccess()
        {
        }

        static string myConnectionString = "Server=" + Settings.Default.Server + ";Database=" + Settings.Default.Database + ";User Id=" + Settings.Default.UserId
                                            + ";Password=" + Settings.Default.Password;

        public static bool TestConnection()
        {
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            try
            {
                myConnection.Open();
                myConnection.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                myConnection.Close();
                return false;
                throw ex;
            }
        }

        public static string GetSingleValue(string myQuery)
        {
            string myResult;
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(myQuery, myConnection);

                try
                {
                    myConnection.Open();
                    MySqlDataReader myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    if(myReader != null && myReader.HasRows)
                    {
                        myResult = Convert.ToString(myReader[0].ToString());
                    }
                    else
                    {
                        myResult = "0";
                    }
                }
                catch(MySqlException ex)
                {
                    myConnection.Close();
                    return null;
                    throw ex;
                }
            }
            return myResult;
        }

        public static DataTable ExecuteDataTable(string myQuery)
        {
            DataTable myDataTable = new DataTable();
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(myQuery, myConnection);
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(myCommand);
                try
                {
                    myConnection.Open();
                    myAdapter.Fill(myDataTable);
                    myCommand.Dispose();
                    myConnection.Close();
                    return myDataTable;
                }
                catch(MySqlException ex)
                {
                    myCommand.Dispose();
                    myConnection.Close();
                    return null;
                    throw ex;
                }
            }
        }

        public static void ExecuteNonQuery(List<string> myListQuery)
        {
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand("", myConnection);
                MySqlTransaction myTransaction = myConnection.BeginTransaction();

                try
                {
                    myCommand.Transaction = myTransaction;
                    if(myListQuery.Count > 0)
                    {
                        foreach(string query in myListQuery)
                        {
                            myCommand.CommandText = query;
                            myCommand.ExecuteNonQuery();
                        }
                    }
                    myTransaction.Commit();
                    myCommand.Dispose();
                    myConnection.Close();
                }
                catch(MySqlException ex)
                {
                    try
                    {
                        myTransaction.Rollback();
                    }
                    catch(Exception ex1)
                    {
                        throw ex1;
                    }
                    myCommand.Dispose();
                    myConnection.Close();
                    throw ex;
                }
            }
        }

        public static void ExecuteNonQuery(string myQuery)
        {
            using (MySqlConnection myConnection = new MySqlConnection(myConnectionString))
            {
                MySqlCommand myCommand = new MySqlCommand(myQuery, myConnection);
                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Dispose();
                    myConnection.Close();
                }
                catch(MySqlException ex)
                {
                    myCommand.Dispose();
                    myConnection.Close();
                    throw ex;
                }
            }
        }

    }
}
