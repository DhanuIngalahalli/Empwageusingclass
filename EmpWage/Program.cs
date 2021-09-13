using System;
using System.IO;

namespace EmpWageProblem
{
    public class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        //variables
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonths;
        private int totalEmpWage= 0;
        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonths = maxHoursPerMonths;
        }
        public void computeEmpWage()
        {
            int empHour = 0, workingDays = 0, totalHours = 0;
            int empCheck;
            Random random = new Random();
            while (workingDays <= numOfWorkingDays && totalHours <= maxHoursPerMonths)
            {
                workingDays++;
                empCheck = random.Next(0, 3);
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
                totalHours += empHour;
                Console.WriteLine("Day's {0} Emp hours {1}", workingDays, totalHours);
            }
            totalEmpWage = totalHours *this.empRatePerHour;
            Console.WriteLine("total Emp wage for company: {0} is {1}", company, totalEmpWage);
        }

        public string displaySalary()
        {
            return "total Emp wage for company: " + company + " is " + totalEmpWage;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            EmpWageBuilder dmart = new EmpWageBuilder("Dmart", 20, 15, 85);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.displaySalary());
        }
    }
}
