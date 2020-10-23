using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeBuilderObject
    {
        const int IS_EMPLOYEE_FULL_TIME = 1, IS_EMPLOYEE_PART_TIME = 2;

        private string companyname;
        private int WAGE_PER_HR;
        private int MAX_WORKING_DAYS;
        private int MAX_WORKING_HRS;
        private int totalEmpWage;

        public EmployeeBuilderObject(string companyname, int WAGE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            this.companyname = companyname;
            this.WAGE_PER_HR = WAGE_PER_HR;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
        }

        public void CalculateEmployeeWage()
        {
            Random random = new Random();
            int empHrs = 0, totalWorkingDays = 0;
            int totalWorkingHrs = 0;
            totalWorkingDays++;

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
                totalWorkingHrs += empHrs;

            }
            ///Returns the employee monthly wage
            totalEmpWage = totalWorkingHrs * this.WAGE_PER_HR;
        }
        public string PrintTotalEmpWage()
        {
             return "Company name: " + this.companyname + "Total Employee wage: " + this.totalEmpWage;
        }
    }
}
