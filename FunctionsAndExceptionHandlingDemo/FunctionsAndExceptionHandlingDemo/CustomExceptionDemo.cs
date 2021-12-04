using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandlingDemo
{
    class CustomExceptionDemo
    {
        static void Main()
        {
            try
            {
                Employee employee = new Employee();
                employee.ValidateEmpCode(100, "Scott");
            }catch(InvalidEmpCode ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
