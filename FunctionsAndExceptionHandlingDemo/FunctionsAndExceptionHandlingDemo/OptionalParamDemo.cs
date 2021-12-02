using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandlingDemo
{
    //  This program demo how to work with optional param.
    class OptionalParamDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            //Console.WriteLine(myMath.Size(100));
            Console.WriteLine(myMath.Size(100,20));
           Console.WriteLine( myMath.StudentDetails(30, "Scott", city: "Mumbai"));
            Console.ReadLine();
        }
    }
}
