using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberConsole
{
    class RandomNumber
    {
        public int generateRandomNumber(int min, int max)
        {            
            Random random = new Random();
            int randomNumber = random.Next(min, max);

            return randomNumber;
        }       
    }
}
