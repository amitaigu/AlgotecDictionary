using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data.SQLite;

namespace AlgotecDictionary
{
    public class SQLConnector : IDataConnection
    {
        public Acronym CreateAcronym(Acronym ac)
        {
           


            string sql = "INSERT INTO AcronymTable (Acronym, Acronym_Meaning, Description) Values ('"+ ac._abb+ "', '" + ac._me+ "', '"+ac._de+ "');";
            using (SQLiteConnection myConnection = new SQLiteConnection(GlobalConnections.CnnString("AlgotecAcronymGuide")))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(myConnection))
                {

                    myConnection.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "SELECT * FROM AcronymTable;";
                    //using (SQLiteDataReader reader = cmd.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine("Acronym - {0}, Meaning - {1}, Description - {2}", reader["Acronym"], reader["Acronym_Meaning"], reader["Description"]);
                    //    }
                    //}
                }
            }
            return null;

        }

        public List<String> findAcronym(string abb)
        {
            List<String> matchingAcronyms = new List < String > ();
            using (SQLiteConnection myConnection = new SQLiteConnection(GlobalConnections.CnnString("AlgotecAcronymGuide")))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(myConnection))
                {

                    myConnection.Open();
                    string sql = "SELECT * FROM AcronymTable WHERE Acronym LIKE '%" + abb+ "%';";
                    cmd.CommandText = sql;
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String str= (String.Format("{0} \t {1} \t\t{2}", reader["Acronym"], reader["Acronym_Meaning"], reader["Description"]));
                            //matchingAcronyms.Add(String.Format("{0} \t {1} \t{2}", reader["Acronym"], reader["Acronym_Meaning"], reader["Description"]));
                            matchingAcronyms.Add(str);

                        }

                    }
                }
            }
            return matchingAcronyms;




        }
    }
}
