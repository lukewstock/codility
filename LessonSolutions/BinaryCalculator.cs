namespace LessonSolutions
{
    using System;

    public class BinaryCalculator
    {
        public static int CalculateBinaryGap(int i)
        {
            var binaryString = Convert.ToString(i, 2);
            var startCount = false;
            var binaryGapCounter = 0;
            var maxCount = 0;

            foreach (var binaryValue in binaryString)
            {
                if (binaryValue == '1')
                {
                    if (binaryGapCounter > maxCount)
                    {
                        maxCount = binaryGapCounter;
                    }

                    startCount = true;
                    binaryGapCounter = 0;
                }

                if (startCount && binaryValue == '0')
                {
                    binaryGapCounter++;
                }                
            }

            return maxCount;
        }
    }
}