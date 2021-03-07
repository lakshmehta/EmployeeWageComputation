using System;

namespace DailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCkeck = random.Next(0, 2);
            if (empCkeck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
                
        
        }
    }
}
