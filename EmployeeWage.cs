using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmployeeWage
    {
        public const  int Is_Full_Time = 1;
        public const  int Is_Part_Time = 2;
        public const  int Emp_Rate_per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
        public static void MonthlyWages()
        {
           
           int empHrs = 0;
            int empWage = 0;
           int totalEmpWage = 0;

            for (int day = 0; day < Num_Of_Working_Days; day++)
            {



                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Full_Time:
                        Console.WriteLine("Employee is full time");
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        Console.WriteLine("Employee is part time");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        break;
                }
                empWage = empHrs * Emp_Rate_per_Hour;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total emp wage:" + totalEmpWage);
        }
    }
}
