using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class Primefactorial
    {
        public void factorial()
        {
            Console.WriteLine("Enter a number to find prime factors : ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N = N / i;
                }
            }
        }
    }
}