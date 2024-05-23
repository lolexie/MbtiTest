using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MbtiTest
{
    internal class UndefinedAbbreviatureException : Exception
    {
        public UndefinedAbbreviatureException() : base("Undefined abbreviature")
        {
            
        }
    }
}
