using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_EMPLOYEE_FULL_TIME = 1;
            const int WORKING_HRS = 8, WAGE_PER_HR = 20;
            Random random = new Random();
            int empCheck = random.Next(2);
            if( empCheck == IS_EMPLOYEE_FULL_TIME)
            {
                Console.WriteLine("Employee present and daily wage: " + WAGE_PER_HR * WORKING_HRS);
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
