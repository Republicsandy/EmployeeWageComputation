using System;

namespace Employe_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WellCome TO Wmploye Wage Computation Program");

            EmployeePresentAbsent employee = new EmployeePresentAbsent();
            employee.EmpPrsentAbsent();

            Emp_Daily_Wage dailywage = new Emp_Daily_Wage();
            dailywage.EmpDailyWage();
        }
    }
}
