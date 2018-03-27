using System;
using System.Collections.Generic;
using System.Text;

namespace LessonUnitTests
{
    using FluentAssertions;
    using LessonSolutions;
    using NUnit.Framework;

    [TestFixture]
    public class OddOccurenceFinderShould
    {
        [Test]
        public void ReturnInput_WhenOnlyOneElement()
        {
            var elements = new int [1];

            var result = OddOccurenceFinder.FindMismatchingElement(elements);

            result.Should().Be(elements[0]);
        }

        [TestCase(new[]{1, 1, 2}, 2)]
        [TestCase(new[]{1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 7}, 6)]
        public void ReturnMismatchingElement(int[] elements, int expectedResult)
        {
            var result = OddOccurenceFinder.FindMismatchingElement(elements);

            result.Should().Be(expectedResult);
        }
    }
}