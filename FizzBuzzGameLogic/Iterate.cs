using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGameLogic
{
    public class Iterate
    {
        private readonly FizzBuzzGame _fizzBuzzGame;

        public Iterate()
        {
            _fizzBuzzGame = new FizzBuzzGame();
        }

        public void IterateFizzBuzzGame()
        {
            for (int number = 1; number < 20; number++)
            {
                _fizzBuzzGame.CheckNumber(number);
            }
        }
    }
}
