using System;

namespace Employe_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WellCome TO Wmploye Wage Computation Program");
            Console.WriteLine("Enter 1 to check employee present or not");
            Console.WriteLine("Enter 2 to check daily wage of an employee");
            Console.WriteLine("Enter 3 to check the employemet type of an employee");
            Console.WriteLine("Enter 4 to check emp wage using Switch ");
            Console.WriteLine("Enter 5 to check monthly wage using switch ");
            Console.WriteLine("Enter 6 to check emp condition using switch ");
            Console.WriteLine("Enter 7 to check the salary for single companies");
            Console.WriteLine("Enter 8 to check the salary for mutiple companies");
            int getValueByUser = Convert.ToInt32(Console.ReadLine());
            switch (getValueByUser)
            {
                case 1:
                    Employee_Present_Absent employee = new Employee_Present_Absent();
                    employee.EmpPrsentAbsent();
                    break;
                case 2:
                    Emp_Daily_Wage dailywage = new Emp_Daily_Wage();
                    dailywage.EmpDailyWage();
                    break;
                case 3:
                    Emp_Wage_Part_Time emptime = new Emp_Wage_Part_Time();
                    emptime.EmpWagePartTime();
                    break;
                case 4:
                    Switch_Case_Statement switchcase = new Switch_Case_Statement();
                    switchcase.TotalDailyWage();
                    break;
                case 5:
                    Monthly_Emp_wage monthlywage = new Monthly_Emp_wage();
                    monthlywage.TotalMonthlyWage();
                    break;
                case 6:
                    Emp_Wage_Hour_Day_condition dayhours = new Emp_Wage_Hour_Day_condition();
                    dayhours.ConditionDayHours();
                    break;
                case 7:
                    Refactor_Compute_Employee_Wage refactorwagecode = new Refactor_Compute_Employee_Wage();
                    refactorwagecode.ComputeEmployeeWage("Infy",100,20,100);
                    break;
                case 8:
                    Emp_Wage_Multiple_Company multiplecompany = new Emp_Wage_Multiple_Company();
                    multiplecompany.EmployeeWageMultipleCompany("Infy", 100, 20, 100);
                    multiplecompany.EmployeeWageMultipleCompany("Lic", 200, 20, 100);
                    break;
                default:
                    Console.WriteLine("Entered value is incorrect");
                    break;
            }
        }
    }
}
