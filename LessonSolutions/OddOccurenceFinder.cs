using System.Linq;

namespace LessonSolutions
{
    public static class OddOccurenceFinder
    {
        public static int FindMismatchingElement(int[] elements)
        {

            var result = elements[0] ^ elements[1];

            for (int i = 2; i < elements.Length; i++)
            {
                result = result ^ elements[i];
            }

            return result;
        }
    }
}