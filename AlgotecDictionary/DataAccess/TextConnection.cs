using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgotecDictionary
{
    class TextConnection : IDataConnection
    {
        public Acronym CreateAcronym(Acronym ac)
        {
            return ac;
        }

        public List<String> findAcronym(string abb)
        {
            return null;
        }
    }
}
