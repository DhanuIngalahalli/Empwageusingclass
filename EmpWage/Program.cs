using System;


namespace EmpWage
{
    public class Program
    {
        public const int IS_PRESENT = 0;
        public const int IS_ABSENT = 1;
        public const int IS_PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOUR = 8;
        public const int MAX_WORKING_DAY = 20;
        public const int MAX_WORKING_HOUR = 100;

        public static void computeEmpWage()
        {
            int empHour = 0, salary = 0, workingDay = 0, totalHours = 0;
            int empCheck;
            Random random = new Random();
            while (workingDay <= MAX_WORKING_DAY && totalHours <= MAX_WORKING_HOUR)
            {
                empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PRESENT:
                        empHour = FULL_DAY_HOUR;
                        workingDay++;
                        Console.WriteLine("Employee is working full time");
                        break;
                    case IS_PART_TIME:
                        empHour = FULL_DAY_HOUR;
                        workingDay++;
                        Console.WriteLine("Employee is working part time");
                        break;
                    case IS_ABSENT:
                        Console.WriteLine("Employee is not working");
                        empHour = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                totalHours += empHour;
            }
            salary = totalHours * WAGE_PER_HOUR;
            Console.WriteLine("Working day is " + workingDay + " total working hour " + totalHours + " Salary earn " + salary);
        }
        static void Main(string[] args)
        {
               computeEmpWage();
        }
    }
}
