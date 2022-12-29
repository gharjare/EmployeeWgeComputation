using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmployeeWage
    {
        public static void CheckPartTime()
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_Rate_per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0,2);
            if(empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else if(empCheck == Is_Part_Time)
            {
                Console.WriteLine("Employee is absent");
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_per_Hour;
            Console.WriteLine("Employeewage" + empWage);
        }
    }
}
