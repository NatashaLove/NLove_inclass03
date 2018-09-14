using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLove_inclass03
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MINIMUM = 1;
            const int MAXIMUM = 11;
            int rNumber;
            //Random - class - generating random number:
            Random rng = new Random();
            rNumber = rng.Next(MINIMUM, MAXIMUM);

            // ask for numeric input
            Console.Write("Enter a number : ");
            //store the input as integer
            int answer = Convert.ToInt32(Console.ReadLine());
            // can use: int answer = Int32.Parse(Console.ReadLine());

            if (answer < rNumber)
            {
                //the same result - two ways to put it:
                Console.WriteLine("The correct answer was {0}. Your answer was too low.", rNumber);
                Console.WriteLine($"The correct answer was {rNumber}. Your answer was too low.");
            }
            else if (answer > rNumber)
            {
                Console.WriteLine("The correct answer was {0}. Your answer was too high.", rNumber);
                Console.WriteLine($"The correct answer was {rNumber}. Your answer was too high.");
            }
            else if (answer < MINIMUM || answer >= MAXIMUM)
            {
                Console.WriteLine("The answer must be between {0} and {1}.", MINIMUM, MAXIMUM);
                Console.WriteLine($"The answer must be between {MINIMUM} and {MAXIMUM}.");
            }
            else
            {
                Console.WriteLine("Your answer was correct!");
            }

            Console.Write("Are you hungry? ");
            string hunger = Console.ReadLine().ToUpper(); // strings method - changes all characters to upper case. ToLower - changes to all lower case

            switch (hunger)
            {
                //first check for YES
                case "Y":
                case "YES":
                    Console.WriteLine("Grab a snickers!");
                    break;

                case "N":
                case "NO":
                    Console.WriteLine("You just had a snickers, didn't you?");
                    break;

                default:
                    Console.WriteLine("I don't understand.");
                    break;
            }
            // wait for user to respond
            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }
    }
}
