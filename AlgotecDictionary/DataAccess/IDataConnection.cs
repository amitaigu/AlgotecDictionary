using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgotecDictionary
{
    public interface IDataConnection
    {
        Acronym CreateAcronym(Acronym ac);
        List<String> findAcronym(String abb);
            
    }
}
