using FluentAssertions;

namespace LessonUnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit.Framework;

    [TestFixture]
    public class CyclicRotatorShould
    {
        [TestCase(new[] { 1, 1, 1 }, 3, 3)]
        public void DoNothing_WhenTheLengthOfArrayMatchesNumberToShiftBy(int[] arrayToShift, int arrayLength, int shiftRightBy)
        {
            var result = CyclicRotator.ShiftArrayRight(arrayToShift, arrayLength, shiftRightBy);

            result.Should().BeSameAs(arrayToShift);
        }
    }

    public class CyclicRotator
    {
        public static int[] ShiftArrayRight(int[] arrayToShift, int arrayLength, int shiftRightBy)
        {
            return arrayToShift;
        }
    }
}
