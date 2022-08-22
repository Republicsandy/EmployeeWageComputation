using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_Wage_Computation
{
    class Employee_Present_Absent
    {
        public void EmpPrsentAbsent()
        {
            //Constant
            int IS_Full_Time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            //Computation

            if (empCheck == IS_Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Adsent");
            }
        }
    }
}
