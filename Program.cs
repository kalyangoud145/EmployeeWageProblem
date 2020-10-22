using System;

namespace EmployeeWageProblem
{
    class Program
    {
        //constants 
        public const int IS_EMPLOYEE_FULL_TIME = 1, IS_EMPLOYEE_PART_TIME = 2;
   

        static void Main(string[] args)
        {
            ///Printing the total employee wage for differnt companies
            Console.WriteLine("Employee Monthly wage: " + CalculateEmployeeWage("Microsoft",50,24,60));
            Console.WriteLine("Employee Monthly wage: " + CalculateEmployeeWage("Google", 90, 25, 70));
        }

        public static int CalculateEmployeeWage(string companyname, int WAGE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS)
        {
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
            ///Returns the employee monthly wage
            return (totalWorkingHrs * WAGE_PER_HR);
        }
    }
}