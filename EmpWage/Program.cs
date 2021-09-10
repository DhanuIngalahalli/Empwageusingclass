using System;

namespace EmpWage
{
    public class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHour = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            
            while (totalWorkingDays < numOfWorkingDays && totalEmpHrs <= maxHoursPerMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHour = 4;
                        break;
                    case IS_FULL_TIME:
                        empHour = 8;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                totalEmpHrs += empHour;
                Console.WriteLine("Day:" + totalWorkingDays + "Emp Hrs:" + empHour);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("total Emp wage for company:" + company + "is:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            computeEmpWage("Dmart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
