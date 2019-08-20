using System;
using Oracle.DataAccess.Client;
using System.Data.SQLite;


class OraTest
{

    static void Main()
    {
        string sqlQuery = "INSERT INTO AcronymTable (Acronym, Acronym_Meaning, Description) Values ('WFM', 'Work Flow Mangager', 'Manages the workflow');";
        using (SQLiteConnection myConnection = new SQLiteConnection("Data Source=C:/Users/amitaig/source/repos/AlgotecDictionary/AlgotecAcronymGuide/DictionaryDB.db;"))
        {
            using (SQLiteCommand cmd = new SQLiteCommand(myConnection))
            {
                myConnection.Open();
                cmd.CommandText = sqlQuery;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM AcronymTable;";
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Console.WriteLine("Acronym - {0}, Meaning - {1}, Description - {2}", reader["Acronym"] , reader["Acronym_Meaning"], reader["Description"]);
                    }
                }
            }
        }
    }
}