using System;

namespace Basics1
{
    class convertDays
    {
        public void convertDaysxx()
        {
            Console.WriteLine("Enter number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            int months = days / 30;
            int weeks = days / 7;
            Console.WriteLine("Days: " + days);
            Console.WriteLine("Years: " + years);
            Console.WriteLine("Months: " + months);
            Console.WriteLine("Weeks: " + weeks);
        }
    }
}