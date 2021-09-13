using System;

namespace Emp_Wage
{
    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Company Wages ::");
            //Object for CalculateWages class 
            CalculateWages cal = new CalculateWages();
            //calling check method
            cal.check("Dmart", 150, 24, 100); //("Company Name", Company_Number, Work_Days, Work_Hours)
            cal.check("Reliance", 200, 20, 80);
            cal.check("More", 001, 26, 120);
            cal.print();
        }
    }
}
