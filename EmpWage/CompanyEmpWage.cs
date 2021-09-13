using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblem
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonths;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonths)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonths = maxHoursPerMonths;
        }

        public void setSalary(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string displaySalary()
        {
            return "total Emp wage for company: " + company + " is " + totalEmpWage;
        }
    }
}
