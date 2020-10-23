using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem 
{
    class EmployeeBuildArray : IComputeWage
    {
        /// <summary>
        /// Constants
        /// </summary>
        const int IS_EMPLOYEE_FULL_TIME = 1, IS_EMPLOYEE_PART_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        
        public  EmployeeBuildArray()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string,CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string company, int WAGE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, WAGE_PER_HR, MAX_WORKING_DAYS, MAX_WORKING_HRS);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company,companyEmpWage);
        }
        /// <summary>
        /// for switching across multiple comapanies at a time
        /// </summary>
        public void ComputeEmpWage()
        {
           foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
            }
        }

        public int GetTotalWage(string companyName)
        {
            return this.companyToEmpWageMap[companyName].totalEmpWage;
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

