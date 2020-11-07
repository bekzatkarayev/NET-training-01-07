using System;
using System.Text;

namespace Task04
{
    public class Program
    {
        /// <summary>
        /// Concatenates one string to another, excluding repeating characters.
        /// </summary>
        /// <param name="str1">First string.</param>
        /// <param name="str2">Second string.</param>
        /// <returns>Resulting string.</returns>
        public static string ConcatenateStringsWithoutRepeat(string str1, string str2)
        {
            int index = 0;
            var chars = new char[str1.Length + str2.Length];

            foreach (var letter in str1)
            {
                if (!Array.Exists(chars, c => c == letter))
                {
                    chars[index] = letter;
                    index++;
                }
            }

            foreach (var letter in str2)
            {
                if (!Array.Exists(chars, c => c == letter))
                {
                    chars[index] = letter;
                    index++;
                }
            }

            var result = new StringBuilder();

            for (index = 0; index < chars.Length; index++)
            {
                if (chars[index] == '\0')
                {
                    break;
                }

                result.Append(chars[index]);
            }

            return result.ToString();
        }

        public static void Main()
        {
        }
    }
}
