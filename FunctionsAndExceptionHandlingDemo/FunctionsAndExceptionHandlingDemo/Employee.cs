using System;


namespace FunctionsAndExceptionHandlingDemo
{
    //  This class throws an exception after validating EmpCode.
    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }

        public void ValidateEmpCode(int empCode,string empName)
        {
            this.EmpCode = empCode;
            this.EmpName = empName;
            if (this.EmpCode <= 0)
            {
                throw new InvalidEmpCode();
            }
            else
            {
                Console.WriteLine($"Code={this.EmpCode}\tName={this.EmpName}");
            }
        }
    }
}
