using System;

namespace EmployeeWageProblem
{
    class Program
    {


        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            EmployeeBuilderObject microsoft = new EmployeeBuilderObject("Microsoft", 50, 24, 60);
            EmployeeBuilderObject google = new EmployeeBuilderObject("Google", 90, 25, 70);
            microsoft.CalculateEmployeeWage();
            Console.WriteLine(microsoft.PrintTotalEmpWage());
            google.CalculateEmployeeWage();
            Console.WriteLine(google.PrintTotalEmpWage());
        }


    }
}