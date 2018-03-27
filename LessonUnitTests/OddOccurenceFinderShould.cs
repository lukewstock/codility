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
    }
}