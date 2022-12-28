using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public class Employee
    {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2, Rate_Per_Hour = 20;
        int empHrs = 0, EmpDailyWage = 0;

        public void CheckAttendance()
        {
            
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    Console.WriteLine("Employee is Part Time");
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is Full Time");
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            EmpDailyWage = Rate_Per_Hour * empHrs;
            Console.WriteLine("Employee Wage is " + EmpDailyWage);

        }
    }
}
