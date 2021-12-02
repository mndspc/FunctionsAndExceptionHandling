using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndExceptionHandlingDemo
{
    class MyMath
    {
        /// <summary>
        /// This function add two numbers and print its value.
        /// </summary>
        public void Add()
        {
            int num1 = 30;
            int num2 = 40;
            int sum = num1 + num2;
            Console.WriteLine($"Sum is :{sum}");
        }
        /// <summary>
        /// This function add two numbers and print its value.
        /// </summary>
        /// <param name="num1">Enter a First Number</param>
        /// <param name="num2">Enter a second Number</param>
        /// <returns>Sum of two numbers</returns>
        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int Increment(int x)
        {
            x++;
            return x;
            
        }

        public int Increment(ref int x)
        {
            x++;
            return x;
        }

        public double GstCalc(double proAmount, double per, out double gstAmount)
        {
            double gstAmt = proAmount / 100 * per;
            gstAmount = gstAmt; // out param must be assigned
            double proAmt = proAmount + gstAmount;
            return proAmt;
        }

        public int Size(int height, int width = 10)
        {
            return height * width;
        }

        public string StudentDetails(int age, string name, string state = "MH", string city = "Pune")
        {
            return $"Age={age}\nName={name}\nCity={city}\nState={state}";
        }

        public void PrintMarks(params int[] marks)
        {
            foreach (var mark in marks)
            {
                Console.Write($"{mark}\t");
            }
        }


    }

}
