using System;
using System.Diagnostics;

namespace Task05
{
    public class Program
    {
        /// <summary>
        /// FindNextBiggerNumber method finds next bigger integer 
        /// which contains same exact digits as the input integer.
        /// </summary>
        /// <param name="number">Input integer.</param>
        /// <returns>Matching integer is returned, if no such integer is found, it returns -1.</returns>
        public static int FindNextBiggerNumber(int number, out TimeSpan executionTime)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int runner = number;
            int length = 0;

            while (runner > 0)
            {
                runner /= 10;
                length++;
            }

            var digits = new int[length];

            while (number > 0)
            {
                digits[runner] = number % 10;
                number /= 10;
                runner++;
            }

            Array.Reverse(digits);
            for (int index = length - 2; index >= 0; index--)
            {
                if (digits[index] < digits[index + 1])
                {
                    int temp = digits[index];
                    digits[index] = digits[index + 1];
                    digits[index + 1] = temp;
                    Array.Sort(digits, index + 1, length - index - 1);
                    stopWatch.Stop();
                    executionTime = stopWatch.Elapsed;
                    return int.Parse(string.Join(string.Empty, digits));
                }
            }

            stopWatch.Stop();
            executionTime = stopWatch.Elapsed;
            return -1;
        }

        public static void Main()
        {
        }
    }
}
