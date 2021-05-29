using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class PowerOf2
    {
        public void power()
        {
            Console.WriteLine("Enter a value of n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                long final = Convert.ToInt32(Math.Pow(2, i));
                Console.WriteLine(final);


            }
        }
    }
}
