using System;

namespace P0004
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = { 1, 3, 4, -1 };
            Console.WriteLine(FindMissingInt(d));
        }

        static int FindMissingInt(int[] data)
        {
            bool[] checkList = new bool[data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] > 0 && data[i] <= data.Length)
                {
                    checkList[data[i]-1] = true;
                }
            }
            return Array.IndexOf(checkList, false)+1;
        }
    }
}
