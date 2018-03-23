namespace LessonUnitTests
{
    using System;
    using System.Linq;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class CyclicRotatorShould
    {
        [TestCase(new[] { 1, 1, 1 }, 3, 3, new [] { 1, 1, 1 })]
        [TestCase(new[] { 1, 2, 3 }, 3, 15, new [] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 2 }, 3, 1, new [] { 2, 1, 2 })]
        [TestCase(new[] { 1, 3, 2, 2 }, 4, 2, new [] { 2, 2, 1, 3 })]
        [TestCase(new[] { 1, 3 }, 2, 2, new [] { 1, 3 })]
        [TestCase(new[] { 1, 3 }, 2, 3, new [] { 3, 1 })]
        [TestCase(new[] { 1, 3 }, 2, 15, new [] { 3, 1 })]
        public void DoNothing_WhenTheLengthOfArrayMatchesNumberToShiftBy(int[] arrayToShift, int arrayLength, int shiftRightBy, int[] expectedArray)
        {
            var result = CyclicRotator.ShiftArrayRight(arrayToShift, arrayLength, shiftRightBy);

            result.Should().ContainInOrder(expectedArray);
        }
    }

    public class CyclicRotator
    {
        public static int[] ShiftArrayRight(int[] arrayToShift, int arrayLength, int shiftRightBy)
        {
            while (shiftRightBy > arrayLength)
            {
                shiftRightBy = arrayLength;
            }

            var end = arrayToShift.TakeLast(shiftRightBy);
            var begining = arrayToShift.Take(arrayToShift.Length - shiftRightBy);
            return end.Concat(begining).ToArray();
        }
    }
}
