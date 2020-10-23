using System;

namespace EmployeeWageProblem
{
    class Program
    {


        /// <summary>
        /// Defines the entry point of the application.
        /// main class where methods are called
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            
            EmployeeBuildArray employeeBuilder = new EmployeeBuildArray();
            employeeBuilder.AddCompanyEmpWage("Microsoft", 50, 24, 60);
            employeeBuilder.AddCompanyEmpWage("Google", 90, 25, 70);
            employeeBuilder.ComputeEmpWage();
        }


    }
}