using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    /// <summary>
    /// Interface for Computing employee wage
    /// </summary>
    interface IComputeWage
    {
        /// <summary>
        /// Adds the company emp wage.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="WAGE_PER_HR">The wage per hr.</param>
        /// <param name="MAX_WORKING_DAYS">The maximum working days.</param>
        /// <param name="MAX_WORKING_HRS">The maximum working HRS.</param>
        public void AddCompanyEmpWage(string company, int WAGE_PER_HR, int MAX_WORKING_DAYS, int MAX_WORKING_HRS);
        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        public void ComputeEmpWage();
        /// <summary>
        /// Gets the total wage of employee
        /// </summary>
        /// <param name="company">The company.</param>
        /// <returns></returns>
        public int GetTotalWage(string company);


    }
}
