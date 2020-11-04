using System;
using System.Text;

namespace Task01
{
    public class Program
    {
        /// <summary>
        /// Replaces certain string of bits of bitwise representaion of one integer with another integer.
        /// </summary>
        /// <param name="numberSource">a number which bits are replaced.</param>
        /// <param name="numberIn">a number which bits are used for replacement.</param>
        /// <param name="i">position of last replaced bit.</param>
        /// <param name="j">position of first replaced bit.</param>
        /// <returns>resulting integer with replaced bits.</returns>
        public static int InsertNumber(int numberSource, int numberIn, int i, int j)
        {
            var binarySource = Convert.ToString(numberSource, 2);
            var binaryIn = Convert.ToString(numberIn, 2);
            var maxLength = Convert.ToString(int.MaxValue, 2).Length;
            int insertLength = j - i + 1;
            int unchangedLength = maxLength - binarySource.Length + 1;
            int runnerIn = 0;

            StringBuilder binaryResult = new StringBuilder(maxLength);

            for (int index = 0; index <= maxLength; index++)
            {
                if (index >= maxLength - j && index <= maxLength - i)
                {
                    if (insertLength > binaryIn.Length)
                    {
                        binaryResult.Append('0');
                        insertLength--;
                    }
                    else
                    {
                        binaryResult.Append(binaryIn[runnerIn]);
                        runnerIn++;
                    }
                }
                else if (index >= unchangedLength)
                {
                    binaryResult.Append(binarySource[index - unchangedLength]);
                }
                else
                {
                    binaryResult.Append('0');
                }
            }

            string result = Convert.ToString(binaryResult);

            return Convert.ToInt32(result, 2);
        }

        public static void Main()
        {
        }
    }
}
