using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Wage_Computation
{
    class Emp_Wage_Part_Time
    {
        public void EmpWagePartTime()
        {
            //Constant
            int IS_Part_Time = 1;
            int IS_Full_Time = 2;
            int EMP_RATE_PER_HOUR = 20;
            //Varibles
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            //Computation

            if (empCheck == IS_Part_Time)
            {
                empHrs = 4;
            }
            else if(empCheck == IS_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employe Wage for a Day:" + empWage);
        }
    }
}
