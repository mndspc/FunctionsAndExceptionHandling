using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath myMath = new MyMath();
            myMath.Add();
            Console.WriteLine(myMath.Add(30, 40));
            Console.ReadLine();
        }
    }
}
