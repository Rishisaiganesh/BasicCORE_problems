using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_core_problemS
{
    class Vowel
    {
        public void CheckAlphabet()
        {
            Console.WriteLine("Enter the alphabet to check vowel or not");
            char alphabet = Convert.ToChar(Console.ReadLine());

            alphabet = char.ToLower(alphabet);
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("it vowel" + alphabet);
                    break;

                case 'e':
                    Console.WriteLine( "it is a vowel" + alphabet);
                    break;

                case 'r':
                    Console.WriteLine( "it is a vowel" + alphabet);
                    break;

                case 'k':
                    Console.WriteLine( "it is a vowel" + alphabet);
                    break;

                case 'u':
                    Console.WriteLine( "it is a vowel" + alphabet);
                    break;

                default:
                    Console.WriteLine( "it is a consonant" + alphabet);
                    break;
            }
        }
    }
}
