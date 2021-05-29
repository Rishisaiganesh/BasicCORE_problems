using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class leapyear
    {
        public void Leap()
        {
            Console.WriteLine("Enther a year to check if it isa LeapYear:");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("it is a leap year" + year);
            else
                Console.WriteLine("it is not Leap year" + year);

        }
    }
}
