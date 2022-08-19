using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Wage_Computation
{
    class SwitchCaseStatement
    {
        public const int IS_Full_Time = 1;
        public const int IS_Part_Time = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public void TotalDailyWage()
        {
            int empHrs = 0;
            int empWage = 0;
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
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage" + empWage);
        }
    }
}
