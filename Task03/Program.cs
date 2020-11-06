using System;

namespace Task03
{
    public class Program
    {
        /// <summary>
        /// Searches for an element in the given array, for which sums of all other elements 
        /// on the right side and on the left side of it are equal.
        /// </summary>
        /// <param name="numbers">Input array of real numbers.</param>
        /// <returns>Index of the matching element or null, if not found.</returns>
        public static int? FindElementOfBalancedArray(ref decimal[] numbers)
        {
            if (numbers.Length < 3)
            {
                return null;
            }

            int? result = null;

            for (int index = 1; index < numbers.Length - 1; index++)
            {
                decimal sumLeft = 0;
                decimal sumRight = 0;

                for (int runner = 0; runner < index; runner++)
                {
                    sumLeft += numbers[runner];
                }

                Console.Write(sumLeft + " ");

                for (int runner = index + 1; runner < numbers.Length; runner++)
                {
                    sumRight += numbers[runner];
                }

                Console.Write(sumRight + "\n");

                if (sumLeft == sumRight)
                {
                    result = index;
                    break;
                }
            }

            return result;
        }

        public static void Main()
        {
            decimal[] numbers = new decimal[] { 1.25M, 17.456M, -2.36M, -41.2M, 4.2M, 1.11M, 6.8M, -19.544M };
            FindElementOfBalancedArray(ref numbers);
        }
    }
}
