using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants 
            const int IS_EMPLOYEE_FULL_TIME = 1, IS_EMPLOYEE_PART_TIME = 2;
            const int WAGE_PER_HR = 20, MAX_WORKING_HRS = 100;
            const int MAX_WORKING_DAYS = 20;

            Random random = new Random();
            int empHrs = 0, totalWorkingDays = 0;
            int totalWorkingHrs = 0;

            //While loop for checking the total employee working days 
            while (totalWorkingHrs <= MAX_WORKING_HRS && totalWorkingDays <= MAX_WORKING_DAYS)
            {
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_EMPLOYEE_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_EMPLOYEE_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalWorkingDays++;
                totalWorkingHrs += empHrs;

            }
            ///Printing the total employee wage for 20 days and maximum working hrs are 100
            Console.WriteLine("Employee Monthly wage: " + (totalWorkingHrs * WAGE_PER_HR));
        }
    }
}