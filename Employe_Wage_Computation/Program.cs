using System;
using System.Collections.Generic;
using System.Text;

namespace Employe_Wage_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            EmpWageBuliderArray empWageBuilder = new EmpWageBuliderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}
