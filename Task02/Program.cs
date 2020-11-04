using System;

namespace Task02
{
    public class Program
    {
        /// <summary>
        /// FindMax method searches for maximum element in the input array recursively
        /// </summary>
        /// <param name="numbers">reference to an unsorted integer array</param>
        /// <returns>maximum element of the array</returns>
        public static int FindMax(ref int[] numbers)
        {
            int size = numbers.Length;

            if (size > 1)
            {
                if (numbers[size - 2] < numbers[size - 1])
                {
                    numbers[size - 2] = numbers[size - 1];
                }

                Array.Resize(ref numbers, size - 1);
                FindMax(ref numbers);
            }

            return numbers[0];
        }

        public static void Main()
        {
        }
    }
}
