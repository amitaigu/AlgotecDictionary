using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgotecDictionary
{
    public static class GlobalConnections
    {
        public static List<IDataConnection> connList { get; private set; } = new List<IDataConnection>();
        public static void InitialConnections(bool database, bool textFiles)
        { 
            if(database)
            {
                Console.WriteLine("creating sql connections");
                SQLConnector sql = new SQLConnector();
                connList.Add(sql);

                // TODO - create SQL connection
            }
           
        }

        public static string CnnString(string name)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}

