using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public class Employee
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2;


        public static int computeEmpWage(string company, int Rate_Per_Hour, int WorkingDays, int Max_Hrs)
        {
            int empHrs = 0, MonthlyWage = 0, totalHrs = 0, TotalDays = 0;
            Console.WriteLine("Company: " + company);

            while (totalHrs < Max_Hrs && TotalDays <= WorkingDays)
            {
                TotalDays++;
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
                totalHrs += empHrs;              
            }

            MonthlyWage = Rate_Per_Hour * totalHrs;
           Console.WriteLine("Total Employee Wage is " + MonthlyWage);
           return MonthlyWage;

        }
    }
}
