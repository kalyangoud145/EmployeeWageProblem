using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_EMPLOYEE_FULL_TIME = 1, IS_EMPLOYEE_PART_TIME = 2;
            const int FULL_TIME_WORKING_HRS = 8, WAGE_PER_HR = 20;
            const int PART_TIME_WORKING_HRS = 4;

            Random random = new Random();
            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case IS_EMPLOYEE_FULL_TIME:
                    Console.WriteLine("Employee fulltime and daily wage: " + WAGE_PER_HR * FULL_TIME_WORKING_HRS);
                    break;
                case IS_EMPLOYEE_PART_TIME:
                    Console.WriteLine("Employee Parttime and daily wage: " + WAGE_PER_HR * PART_TIME_WORKING_HRS);
                    break;
                default:
                    Console.WriteLine("Employee absent");
                    break;
            }
        }
    }
}