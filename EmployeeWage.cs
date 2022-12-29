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
        public const int Max_Hrs_In_Month = 100;
        public static int ComputeEmpWage(string Company,int empRatePerHrs,int numOfWorkingDays,int maxHrsPerMonth)
        {
           
           int empHrs = 0;
            int empWage = 0;
           int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            while(totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:"+ totalWorkingDays+"Emp Hrs:" + empHrs);
            }
            totalEmpWage = totalEmpHrs * Emp_Rate_per_Hour;
            Console.WriteLine("Total emp wage for comapany:" +Company+"Is:"+ totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("Flipcart",30,2,10);
            ComputeEmpWage("Amazon", 40, 5, 20);
        }
    }
}
