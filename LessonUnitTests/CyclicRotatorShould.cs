namespace LessonUnitTests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class CyclicRotatorShould
    {
        [TestCase(new[] { 1, 1, 1 }, 3, new [] { 1, 1, 1 })]
        [TestCase(new[] { 1, 2, 3 }, 15, new [] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 2 }, 1, new [] { 2, 1, 2 })]
        [TestCase(new[] { 1, 3, 2, 2 }, 2, new [] { 2, 2, 1, 3 })]
        [TestCase(new[] { 1, 3 }, 2, new [] { 1, 3 })]
        [TestCase(new[] { 1, 3 }, 3, new [] { 3, 1 })]
        [TestCase(new[] { 1, 3 }, 15, new [] { 3, 1 })]
        [TestCase(new[] { 3, 8, 9, 7, 6 }, 3, new [] { 9, 7, 6, 3, 8 })]
        [TestCase(new int [0], 0, new int [0])]
        public void ShiftEachElementOfTheArrayToTheRightBySpecifiedAmount(int[] arrayToShift, int shiftRightBy, int[] expectedArray)
        {
            var result = CyclicRotator.ShiftArrayRight(arrayToShift, shiftRightBy);

            result.Should().ContainInOrder(expectedArray);
        }
    }
}
