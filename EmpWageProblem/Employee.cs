using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblem
{
    public class Employee
    {
        int IS_FULL_TIME = 1, Rate_Per_Hour = 20, empHrs = 0, EmpDailyWage = 0;

        public void CheckAttendance()
        {
            
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            EmpDailyWage = Rate_Per_Hour * empHrs;
            Console.WriteLine("Employee Wage is " + EmpDailyWage);

        }
    }
}
