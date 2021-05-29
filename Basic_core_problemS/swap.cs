using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class swap
    {
        public void Swap(int number1, int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Swaping Two Numbers:" + number1 + number2);

        }

        internal void Swap()
        {
            throw new NotImplementedException();
        }
    }
}
