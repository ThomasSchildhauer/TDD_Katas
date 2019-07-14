using System;
using System.Collections.Generic;
using FluentAssertions;
using Kata_StringCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata_StringCalculatorTest
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        [DataRow("0,0", 0)]
        [DataRow("1,0", 1)]
        [DataRow("1,1", 2)]
        public void Add_Should_Return_Correct_Number(string numbers, int expected)
        {
            // ARRANGE
            StringCalculator SUT = new StringCalculator();

            // EXECUTION
            var actual = SUT.Add(numbers);

            // ASSERTION
            expected.Should().Be(actual);
        }

        [TestMethod]
        [DataRow("0,0", 0, 0)]
        [DataRow("0,1", 0, 1)]
        [DataRow("0,2", 0, 2)]
        public void CutString_Should_Return_Two_Correct_Numbers(string numbers, int expected1, int expected2)
        {
            // ARRANGE
            StringCalculator SUT = new StringCalculator();

            // EXECUTION
            var actual = SUT.CutString(numbers);

            // ASSERTION 
            expected1.Should().Be(actual[0]);
            expected2.Should().Be(actual[1]);
        }
    }
}
