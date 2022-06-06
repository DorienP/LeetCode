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

            return Helper(input, count);
        }

        private int Helper(string input, int count)
        {
            if (input.Length <= 1) return count;

            string sub = input.Shift(1);

            if (input[0] == input[1])
            {
                count += 1;
                string result = sub[0].Flip() + sub.Substring(1);
                Console.WriteLine($"sub:{sub}input:{input}flipped:{result}");
                return Helper(result, count);
            } else {
                return Helper(sub, count);
            }
        }

        static void Main()
        {
            MinOperations op = new MinOperations();
            Console.WriteLine(op.Run("1011"));
        }
    }


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