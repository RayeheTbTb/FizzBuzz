using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGameLogic
{
    public class FizzBuzzGame
    {
        public string CheckNumber(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return "No FizzBuzz";
        }
    }
}
