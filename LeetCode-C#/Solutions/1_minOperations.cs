//1758. Minimum Changes To Make Alternating Binary String
using System;

namespace Solutions
{

    public class MinOperations
    {
        public int Run(string s)
        {
            string input = s;
            int count = 0;
            int index = 0;

            int result = Helper(input, count, index);
            return Math.Min(result, s.Length - result);
        }

        private int Helper(string input, int count, int index)
        {
            if (input.Length <= 0) return count;

            string sub = input.Shift(1);
            string bit = "01";

            if ( bit[index % 2] == input[0] )
            {
                count += 1;
                index += 1;
                return Helper(sub, count, index);
            } else {
                index += 1;
                return Helper(sub, count, index);
            }
        }

        static void Main()
        {
            MinOperations op = new MinOperations();
            Console.WriteLine(op.Run("1011"));
        }
    }

    // Wanted to mess with extensions
    public static class MyExtensions
    {
        public static string Shift(this string s, int count)
        {
            return s.Remove(0, count);
        }

        public static char Flip(this char c)
        {
            return (c == '1') ? '0' : '1';
        }
    }
}