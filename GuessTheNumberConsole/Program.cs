using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsole
{
    class Program
    {        

        static void Main(string[] args)
        {
            Guess newGuess = new Guess();
            RandomNumber newRndNumber = new RandomNumber();

            int randomNumber = newRndNumber.generateRandomNumber(1, 101);
            int guess = 0;
            int counter = 0;
                       
            do
            {
                guess = newGuess.getGuess();
                counter = counter + 1;
                Console.WriteLine("\nGuess count: {0} ", counter);

            } while (newGuess.checkGuess(guess, randomNumber) == false);

        }        
    }
}
