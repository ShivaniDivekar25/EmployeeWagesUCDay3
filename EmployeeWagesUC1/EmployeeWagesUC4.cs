using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesUC1
{
    internal class EmployeeWagesUC4
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        public const int EMP_RATE_PER_HRS = 20;
        public static void EmployeeUC4(int empCheck3)
        {
            int empHrs = 0;
            int empWages = 0;

            switch (empCheck3)
            {
                case IS_PARTTIME:
                    empHrs = 4;
                    break;
                case IS_FULLTIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            empWages = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Employee wages:" + empWages);
        }   
    }
}
