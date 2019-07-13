using System;
using FluentAssertions;
using Kata_FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata_FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(0, "0")]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(6, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(10, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        public void DetermineFizzBuzz_Should_Return_Correct_String(int input, string expected)
        {
            // ARRANGE

            FizzBuzz SUT = new FizzBuzz();
            // RUN
            var actual = SUT.DetermineFizzBuzz(input);
            // ASSERT
            expected.Should().Be(actual);
        }
    }
}
