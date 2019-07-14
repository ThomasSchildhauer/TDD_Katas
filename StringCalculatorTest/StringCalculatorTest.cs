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
        public void Add_Should_Return_0()
        {
            // ARRANGE
            string numbers = "0,0";
            int expected = 0;
            StringCalculator SUT = new StringCalculator();
            // EXECUTION
            var actual = SUT.Add(numbers);
            // ASSERTION
            expected.Should().Be(actual);
        }

        [TestMethod]
        public void Add_Should_Return_1()
        {
            // ARRANGE
            string numbers = "1,0";
            int expected = 1;
            StringCalculator SUT = new StringCalculator();
            // EXECUTION
            var actual = SUT.Add(numbers);
            // ASSERTION
            expected.Should().Be(actual);
        }

        [TestMethod]
        public void Add_Should_Return_2()
        {
            // ARRANGE
            string numbers = "1,1";
            int expected = 2;
            StringCalculator SUT = new StringCalculator();
            // EXECUTION
            var actual = SUT.Add(numbers);
            // ASSERTION
            expected.Should().Be(actual);
        }

        [TestMethod]
        [DataRow("0,0", 0, 0)]
        [DataRow("0,1", 0, 1)]
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
