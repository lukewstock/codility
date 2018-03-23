using System;
using FluentAssertions;
using FluentAssertions.Numeric;
using LessonSolutions;

namespace LessonUnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class BinaryCalculatorShould
    {
        [Test]
        public void ReturnAnInteger()
        {
            var result = BinaryCalculator.CalculateBinaryGap(9);

            result.Should().BeOfType(typeof(int), "", typeof(int));
        }

        [TestCase(9, 2)] //1001
        [TestCase(17, 3)] //10001
        [TestCase(40, 1)] //10100
        [TestCase(82, 2)] //1010010
        [TestCase(561892, 3)] //10001001001011100100
        public void ReturnMaxSequenceOfZerosForBinaryOfInteger(int i, int expectedBinaryGap)
        {
            var result = BinaryCalculator.CalculateBinaryGap(i);

            result.Should().Be(expectedBinaryGap);
        }
    }
}