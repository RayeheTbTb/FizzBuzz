using FizzBuzzGameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz.Logic.Tests
{
    public class FizzBuzzTest
    {
        private readonly FizzBuzzGame _sut;

        public FizzBuzzTest()
        {
            _sut = new FizzBuzzGame();
        }
    }
}
