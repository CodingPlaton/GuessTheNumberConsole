using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsole
{
    class Guess
    {
        public bool checkGuess(int guess, int randomNumber)
        {
            if (guess == randomNumber)
            {
                Console.WriteLine("Right number! =)\n");
                return true;
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("The number is higher!\n");
            }
            else
            {
                Console.WriteLine("The number is lower!\n");
            }
            return false;
        }

        public int getGuess()
        {
            Console.WriteLine("Please insert your guess.");

            int guess = Convert.ToInt32(Console.ReadLine());

            return guess;
        }
    }
}
