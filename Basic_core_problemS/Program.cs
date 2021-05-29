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
            Console.WriteLine("Press5:to check Primefactor");
            Console.WriteLine("Press6: to check ODD or EVEN");
            Console.WriteLine("Press7:To Swaping two numbers");
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
                case 5:
                    Primefactorial Prime = new Primefactorial();
                    Prime.factorial();
                    break;
                case 6:
                    ODDorEVEN check = new ODDorEVEN();
                    check.oddoreven();
                    break;
                case 7:
                    swap obj = new swap();
                    obj.Swap(3, 10);
                    break;
            }
        }
    }
}

