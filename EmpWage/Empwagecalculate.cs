using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Wage
{
    class CalculateWages
    {
        //Class Variables
        public int oneDay_Sal = 0;
        public int perHour_Pay = 20;
        public int perhour;
        public int total_Wage = 0;
        string[] cmp_names = new string[3];
        int[] cmp_wages = new int[3];
        public int i = 0;

        // Random Function Object creation 
        public Random emp_random = new Random();
        //check method for implimentation
        public void check(string cmp_name, int cmp_num, int max_WorkDay, int tot_MaxHours)
        {
            int tot_Workhours = 0;
            int day = 1;
            //Whileloop to check condition Days and Hours for each Company 
            while (day <= max_WorkDay && tot_Workhours <= tot_MaxHours)
            {
                int empcheck = emp_random.Next(0, 3);
                switch (empcheck)
                {
                    case 1:
                        perhour = 8;
                        break;
                    case 2:
                        perhour = 4;
                        break;
                    default:
                        perhour = 0;
                        break;
                }
                day++;
                oneDay_Sal = perhour * perHour_Pay;
                tot_Workhours = tot_Workhours + perhour;
            }
            Console.WriteLine();
            total_Wage = tot_Workhours * perHour_Pay;
            //Displaying the Wages And Information for Comapnies
            Console.WriteLine("Comapny Name is : " + cmp_name);
            Console.WriteLine("Comapny Number is : " + cmp_num);
            Console.WriteLine("Total Wage  For Month is : " + total_Wage);
            Console.WriteLine("Total Hours For Month is : " + tot_Workhours);
            cmp_names[i] = cmp_name;
            cmp_wages[i] = total_Wage;
            i++;
        }

        public void print()
        {
            Console.WriteLine();
            Console.WriteLine("Comapny Names and Wages ::");
            for (int i = 0; i < cmp_names.Length; i++)
            {
                Console.WriteLine("Company Name : " + cmp_names[i] + " And its Wage : " + cmp_wages[i]);
            }
        }
    }
}
