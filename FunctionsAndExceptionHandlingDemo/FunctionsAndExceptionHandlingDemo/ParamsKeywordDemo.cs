using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandlingDemo
{
    //  This program demo how to use params keyword
    class ParamsKeywordDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
          
            myMath.PrintMarks(70, 80, 40, 50);
            Console.ReadLine();
        }
    }
}
