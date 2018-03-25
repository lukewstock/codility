namespace LessonUnitTests
{
//    using System.Linq;

    public class CyclicRotator
    {
        public static int[] ShiftArrayRight(int[] arrayToShift, int shiftRightBy)
        {
            if (shiftRightBy >= arrayToShift.Length)
            {
                shiftRightBy = shiftRightBy % arrayToShift.Length;
            }

//            Solution using System.Linq Extensions
//            var end = arrayToShift.TakeLast(shiftRightBy);
//            var begining = arrayToShift.Take(arrayToShift.Length - shiftRightBy);
//            return end.Concat(begining).ToArray();

            var end = TakeLast(arrayToShift, shiftRightBy);
            var begining = Take(arrayToShift, arrayToShift.Length - shiftRightBy);
            return Concat(end, begining);
        }

        // Emulate System.Linq Extension Methods
        private static int[] TakeLast(int[] array, int count)
        {
            var result = new int[count];

            var skip = array.Length - count;

            for (var i = 0; i < count; i++)
            {
                result[i] = array[i + skip];
            }

            return result;
        }

        private static int[] Take(int[] array, int count)
        {
            var result = new int[count];

            for (var i = 0; i < count; i++)
            {
                result[i] = array[i];
            }

            return result;
        }

        private static int[] Concat(int[] beginning, int[] end)
        {
            //initialiase result
            var result = new int[beginning.Length + end.Length];

            // set beginning of result
            for (var i = 0; i < beginning.Length; i++)
            {
                result[i] = beginning[i];
            }

            // set end of result
            var skip = beginning.Length;
            for (var i = 0; i < end.Length; i++)
            {
                result[i + skip] = end[i];
            }

            return result;
        }
    }
}