using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class EmployeeBuildArray
    {
        /// <summary>
        /// Constants
        /// </summary>
        const int IS_EMPLOYEE_FULL_TIME = 1, IS_EMPLOYEE_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        
        public EmployeeBuildArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string companyname, int WAGE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(companyname, WAGE_PER_HR, MAX_WORKING_DAYS, MAX_WORKING_HRS);
            numOfCompany++;
        }
        /// <summary>
        /// for switching across multiple comapanies at a time
        /// </summary>
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }
        /// <summary>
        /// Computes the employee wage for each company
        /// </summary>
        /// <param name="companyEmpWage">The company emp wage.</param>
        /// <returns></returns>
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalWorkingDays = 0;
            int totalWorkingHrs = 0;
            while (totalWorkingHrs <= companyEmpWage.MAX_WORKING_HRS && totalWorkingDays <= companyEmpWage.MAX_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                totalWorkingDays++;
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
                //Prints total workingdays and totalworking hrs
                Console.WriteLine("Days: " + totalWorkingDays + " Total Employee hrs: " + totalWorkingHrs);
            }
            //Returns the employee wage
            return totalWorkingHrs * companyEmpWage.WAGE_PER_HR;
        }
    }
}

