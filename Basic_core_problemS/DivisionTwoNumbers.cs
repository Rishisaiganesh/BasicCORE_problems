using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class DivisionTwoNumbers
    {
        public void division(int NUMBER1, int Number2)
        {
            int Quotient = NUMBER1 / Number2;
            int remainder = NUMBER1 % Number2;
            Console.WriteLine("THE Quotient is" + Quotient + "THE Remainder is" + remainder);

        }
    }
}
