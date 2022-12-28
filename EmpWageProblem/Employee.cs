using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public class Employee
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, Rate_Per_Hour = 20, Total_Working_Days = 20;
        
        public void CheckAttendance()
        {
            int empHrs = 0, MonthlyWage = 0, totalHrs=0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Full Time");
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part Time");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            for (int day = 0; day < Total_Working_Days; day++)
            {
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
            Console.WriteLine("Employee Wage is " + MonthlyWage);

        }
    }
}
