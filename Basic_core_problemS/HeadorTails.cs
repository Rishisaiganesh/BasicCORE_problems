using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class HeadorTails
    {
        public void Toss()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check < 1)
            {
                Console.WriteLine("Its heads");

            }
            else
            {
                Console.WriteLine("Its tails");

            }
            float PercentageHeads = (1 * 100 / 1);
            Console.WriteLine("PercentageHeads of head is:" + PercentageHeads);
            float PercentageTails = (1 * 100 / 2);
            Console.WriteLine("Percentage of Tails is:" + PercentageTails);
        }
    }
}
