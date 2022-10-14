using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage5Program
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpwage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth, int totalEmpwage)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpwage = totalEmpwage;
        }
        public void setTotalEmpwage(int totalEmpwage)
        {
            this.totalEmpwage = totalEmpwage;
        }
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + "is: " + this.totalEmpwage;
        }

    }
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i <= numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpwage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)

            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs" + empHrs);

            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

    }
}
