using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("helle");
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            AlgotecDictionary.GlobalConnections.InitialConnections(true, true);
            Application.Run(new UI());
        }
    }
}
