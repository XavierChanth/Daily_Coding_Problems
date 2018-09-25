using System;
using System.Collections;

namespace P0013
{
    class Program
    {
        static Queue substring = new Queue();
        static Queue chars = new Queue();

        static void Main(string[] args)
        {
            string s = "abcba";
            int x = MaxStringLength(s, 2);
            Console.WriteLine(x);
        }

        static int MaxStringLength(string s, int k)
        {
            int i;
            int x = 0;
            for (i = 0; i < s.Length; i++)
            {
                if (chars.Contains(s[i]))
                {
                    substring.Enqueue(s[i]);
                }
                else
                {
                    substring.Enqueue(s[i]);
                    chars.Enqueue(s[i]);
                    if (chars.Count > k)
                    {
                        char c = (char)chars.Dequeue();
                        while (substring.Contains(c))
                        {
                            substring.Dequeue();
                        }
                    }
                }
                x = Math.Max(x, substring.Count);
            }
            return x;
        }
    }
}