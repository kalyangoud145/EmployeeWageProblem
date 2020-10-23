/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:EmployeeWageProgram.exe EmployeeWageProgram.cs
 *  Execution:    EmployeeWageProgram.exe 103
 *  
 *  Purpose: Determines employee wage of multiple companies
 *
 *  @author  Kalyan Goud Ravula
 *  @version 1.0
 *  @since   23-10-2020
 *
 ******************************************************************************/
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
            Console.WriteLine("Total wage for the entry comapny: " + employeeBuilder.GetTotalWage("Microsoft"));
        }


    }
}