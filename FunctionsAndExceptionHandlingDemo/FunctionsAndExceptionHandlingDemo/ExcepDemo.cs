using System;


namespace FunctionsAndExceptionHandlingDemo
{
    class ExcepDemo
    {
        static void Main()
        {
           
            try
            {
                
                Console.Write("Please Enter Product Amount:");
                int proAmount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter GST Per:");
                double per = Convert.ToDouble(Console.ReadLine());
                double gstAmt = proAmount / 100 * per;
                double gstAmount = gstAmt;
                double proAmt = proAmount + gstAmount;
                Console.WriteLine($"GST Amount is:{gstAmt} and Total Product Amt:{proAmt}");
            }
           
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("i am finally");
                GC.Collect();
            }
            Console.ReadLine();
        }
    }
}
