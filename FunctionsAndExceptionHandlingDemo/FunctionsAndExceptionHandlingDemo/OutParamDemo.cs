using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandlingDemo
{
    //  This program demo how to use out param
    class OutParamDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            double proAmt = 10000;
            double per = 8;
            double gstAmt;
           Console.WriteLine( myMath.GstCalc(proAmt, per, out gstAmt));
            Console.WriteLine(gstAmt);

            string numStr = "100";
            int result;
           bool flag= int.TryParse(numStr, out result);
           var output= flag ? result :  0 ;
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
