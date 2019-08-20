using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgotecDictionary
{
    public class Acronym
    {
        static int lastID = 0;

        public string _abb { get; set; }
        public string _me { get; set; }

        public string _de { get; set; }
        public Acronym(string abb, string me = "", string de = "")
        {
            _abb= abb;
            _me = me;
            _de = de;
        }

    }
}
