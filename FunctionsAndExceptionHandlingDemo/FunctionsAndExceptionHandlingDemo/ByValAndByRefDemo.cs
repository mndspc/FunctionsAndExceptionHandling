using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandlingDemo
{
    //  This program demo how to use byval and byref param.
    class ByValAndByRefDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            int a = 99;
           //Console.WriteLine( myMath.Increment(a));
           //Console.WriteLine(a);
            Console.WriteLine(myMath.Increment(ref a));
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
