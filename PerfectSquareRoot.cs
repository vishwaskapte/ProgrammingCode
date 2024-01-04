using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCode
{
    public class PerfectSquareRoot
    {
        public int SquareRoot(int Number)
        {
            int i = 1, retunValue = 0;
            while(i * i <= Number)
            {
                retunValue = i; i++;
            }
            return retunValue;
        }
    }
}
