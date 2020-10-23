using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class CompanyEmpWage
    {
    
        public string company;
        public int WAGE_PER_HR;
        public int MAX_WORKING_DAYS;
        public int MAX_WORKING_HRS;
        public int totalEmpWage;
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEmpWage"/> class.
        /// </summary>
        /// <param name="companyname">The companyname.</param>
        /// <param name="WAGE_PER_HR">The wage per hr.</param>
        /// <param name="MAX_WORKING_DAYS">The maximum working days.</param>
        /// <param name="MAX_WORKING_HRS">The maximum working HRS.</param>
        public CompanyEmpWage(string company, int WAGE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS)
        {
            this.company = company;
            this.WAGE_PER_HR = WAGE_PER_HR;
            this.MAX_WORKING_DAYS = MAX_WORKING_DAYS;
            this.MAX_WORKING_HRS = MAX_WORKING_HRS;
        }
        /// <summary>
        /// Sets the total emp wage.
        /// </summary>
        /// <param name="totalEmpWage">The total emp wage.</param>
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        override
        public string ToString()
        {
            return "Company name: " + this.company + " Total Employee wage: " + this.totalEmpWage;
        }
    }
}
