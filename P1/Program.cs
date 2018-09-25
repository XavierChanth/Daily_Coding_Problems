using System;
using System.Collections;

namespace P0001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = { 1, 2, 2, 2, -5 };
            int v = -1;
            Console.Write(ContainsDuplicate(d, v));
        }

        static bool ContainsDuplicate(int[] data, int value)
        {
            Hashtable ht = new Hashtable();
            for(int i = 0; i < data.Length; i++)
            {
                if(ht.ContainsValue(data[i]))
                {
                    return true;
                }
                ht.Add(i, value - data[i]);
            }
            return false;
        }
    }
}
