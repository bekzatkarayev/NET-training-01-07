using System;

namespace Task06
{
    public class Program
    {
        /// <summary>
        /// Searches for integers in the input array, that have given digit. 
        /// </summary>
        /// <param name="digit">A digit that the numbers should have.</param>
        /// <param name="numbers">Input array of integers.</param>
        /// <returns>An array filled with integers, that match the criteria.</returns>
        public static int[] FilterDigit(int digit, ref int[] numbers)
        {
            int[][] digits = new int[numbers.Length][];
            int counter = 0;
            
            for (int index = 0; index < numbers.Length; index++)
            {
                int temp = numbers[index];
                int length = 0;

                while (temp > 0)
                {
                    temp /= 10;
                    length++;
                }

                digits[index] = new int[length];

                for (int runner = 0; runner < length; runner++)
                {
                    digits[index][runner] = numbers[index] % 10;
                    numbers[index] /= 10;
                }
            }

            for (int index = 0; index < numbers.Length; index++)
            {
                if (Array.Exists(digits[index], d => d == digit))
                {
                    Array.Reverse(digits[index]);
                    counter++;
                }
            }

            int[] numbersHaveDigit = new int[counter];
            counter = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (Array.Exists(digits[index], d => d == digit))
                {
                    numbersHaveDigit[counter] = int.Parse(string.Join(string.Empty, digits[index]));
                    counter++;
                }
            }

            return numbersHaveDigit;
        }
        public static void Main()
        {
        }
    }
}
