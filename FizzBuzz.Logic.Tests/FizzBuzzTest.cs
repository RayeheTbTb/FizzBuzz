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

        [Fact]
        public void Should_print_fizz_if_number_is_divisible_by_three()
        {
            var number = 3;

            var expected = _sut.CheckNumber(number);

            expected.Should().Be("Fizz");
        }

        [Fact]
        public void Should_print_buzz_if_number_is_divisible_by_five()
        {

        }
    }
}
