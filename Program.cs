﻿namespace UC6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int IS_ABSENT = 0;
            int EMP_RATE_PER_HOUR = 20;
            int NoOFDAYS = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
                empHrs = 8;

            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            int empWageMonth = empWage * NoOFDAYS;
            Console.WriteLine("Employee Wage:" + empWage);
            Console.WriteLine("Mothly Employee Wage Is:" + empWageMonth);
        }
    }
}