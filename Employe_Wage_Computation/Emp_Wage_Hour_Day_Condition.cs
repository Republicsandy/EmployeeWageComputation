using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Wage_Computation
{
    class Emp_Wage_Hour_Day_condition
    {
        public const int IS_Full_Time = 1;
        public const int IS_Part_Time = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public void ConditionDayHours()
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
           while(totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)   
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
                Console.WriteLine("Day#" + totalWorkingDays + "Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("TOTAL Emp Wage :" + totalEmpWage);
        }
    }
}
