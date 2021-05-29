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
            Console.WriteLine("Press 2 : To check Its a LeapYear or Not");
            Console.WriteLine("Press 3: To check Power of two Numbers");
            Console.WriteLine("Press4: to Check Harmonic NUmber");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    HeadorTails flip = new HeadorTails();
                    flip.Toss();
                    break;
                case 2:
                    leapyear leap = new leapyear();
                    leap.Leap();
                    break;
                case 3:
                    PowerOf2 Power = new PowerOf2();
                    Power.power();
                    break;
                case 4:
                    Harmonic HA = new Harmonic();
                    HA.HarmonicNumberSum();
                    break;
            }
        }
    }
}

