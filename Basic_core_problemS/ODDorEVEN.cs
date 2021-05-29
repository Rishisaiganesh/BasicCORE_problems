using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class ODDorEVEN
    {
        public void oddoreven()
        {
            
            {
                Console.WriteLine("Number is even or odd" );
                int Num = Convert.ToInt32(Console.ReadLine());
                if (Num % 2 == 0)
                    Console.WriteLine("number is even" + Num);
                else
                    Console.WriteLine("number is Odd" + Num);
                

                }

        }

       
    }
}
