using System;
namespace Employe_Wage_Computation
{
    class Emp_Wage_Multiple_Company
    {
        public const int IS_Full_Time = 1;
        public const int IS_Part_Time = 2;
        public void EmployeeWageMultipleCompany(string company, int empRatePerHour, int numberOfWorkingDays, int maxHourPerMonth)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= maxHourPerMonth && totalWorkingDays < numberOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("TOTAL Emp Wage for :" + company + " is "+ totalEmpWage);
        }
    }
}
