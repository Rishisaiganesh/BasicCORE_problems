﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class Harmonic
    {
        public void HarmonicNumberSum()
        {
            float sum = 0;
            Console.WriteLine("Enter a positive integer : ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (float i = 1; i <= N; i++)
            {
                sum = sum + (1 / i);
            }
            Console.WriteLine(sum);
        }
    }
}