using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Wage_Computation
{
    public class Emp_Wage_Builder
    {
        public const int IS_Full_Time = 1;
        public const int IS_Part_Time = 2;
        private string company;
        private int empRatePerHour;
        private int numberOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public Emp_Wage_Builder(string company, int empRatePerHour, int numberOfWorkingDays, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numberOfWorkingDays = numberOfWorkingDays;
            this.maxHoursPerMonth = maxHourPerMonth;
        }
        public void ComputeEmpWage()
        { 
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_Part_Time:
                        empHrs = 4;
                        break;
                    case IS_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("total working Days" + totalWorkingDays + "total emp hrs :" + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("TOTAL Emp Wage for :" + company + " is " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage company:" + this.company + "is" + this.totalEmpWage;
        }
    }
}
