using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage5Program
{
    public class EmpWageObjectBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpwage;

        public EmpWageObjectBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            //variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            //computation
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
                Console.WriteLine("Day#" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            totalEmpwage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage For Company :" + company + "is: " + totalEmpwage);
        }
        public string toString()
        {
            return "Total Emp Wage For Company : " + this.company + "is : " + this.totalEmpwage;
        }
    }
}
