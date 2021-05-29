using System;

namespace Basic_core_problemS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core programs ");
            Console.WriteLine("Enter your choice");
            Console.WriteLine("Press 1: to cheak HeadorTails");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    HeadorTails flip = new HeadorTails();
                    flip.Toss();
                    break;
            }
        }
    }
}

