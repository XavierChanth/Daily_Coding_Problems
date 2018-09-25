using System;

namespace P0009
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = { 5, 5, 10, 100, 10, 5 };
            Console.WriteLine(LargestNonAdjacentSum(d));
        }

        static int LargestNonAdjacentSum(int[] data)
        {
            int with = data[0];
            int without = 0;
            for(int i = 1; i < data.Length; i++)
            {
                int temp;
                if (with > without)
                {
                    temp = with;
                }
                else
                {
                    temp = without;
                }
                with = without + data[i];
                without = temp;
            }
            if(with > without)
            {
                return with;
            }
            return without;
        }
    }
}
