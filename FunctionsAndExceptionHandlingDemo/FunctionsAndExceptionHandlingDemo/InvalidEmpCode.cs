using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandlingDemo
{
    //  This class contains constructor of base class (Exception).
    class InvalidEmpCode:Exception
    {
        public InvalidEmpCode():base("Invalid Employee Code")
        {

        }
    }
}
