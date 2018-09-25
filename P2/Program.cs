using System;

namespace P0002
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = { 1, 2, 3, 4, 5 };
            int[] s = AlternateProduct(d);
            Console.Write("[");
            foreach(int i in s)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\b]");
        }

        static int[] AlternateProduct(int[] data)
        {
            int[] r = new int[data.Length];
            int lSum = data[0];
            int rSum = data[data.Length-1];
            r[0] = 1;
            //Console.WriteLine($"{lSum} {rSum}");
            for(int i = 1; i < data.Length; i++)
            {
                r[i] = lSum;
                lSum *= data[i];
                //Console.WriteLine($"Multiplied by (i) {data[i]}");
            }
            for(int j = data.Length-2; j >= 0; j--)
            {
                r[j] *= rSum;
                rSum *= data[j];
                //Console.WriteLine($"Multiplied by (j) {data[j]}");
            }
            return r;
        }

        static int[] AlternateProductWithDivision(int[] data)
        {
            int masterProduct = 1;
            for(int i = 0; i < data.Length; i++)
            {
                masterProduct *= data[i];
                //Console.WriteLine($"Multiplied by {data[i]}");
            }

            int[] r = new int[data.Length];
            for(int j = 0; j < r.Length; j++)
            {
                r[j] = masterProduct / data[j];
                //Console.WriteLine($"Divided by {data[j]}");
            }
            return r;
        }
    }
}
