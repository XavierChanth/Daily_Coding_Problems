using System;
using System.Collections.Generic;
using System.Linq;

namespace P0018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 5, 2, 7, 8, 7 };
            MaxVals(x, 3);
            //List<int> y = new List<int>();
            //for(int i = 0; i < x.Length; i++)
            //{
            //    y.Add(x[i]);
            //}
            //MaxVals_Old(y, 3);
        }

        //O(n) time / O(k) space
        static void MaxVals(int[] data, int k)
        {
            Queue<int> vals = new Queue<int>();
            for(int i = 0; i < k; i++)
            {
                vals.Enqueue(data[i]);
            }
            Console.WriteLine(vals.Max());
            for(int j = k; j < data.Length; j++)
            {
                vals.Dequeue();
                vals.Enqueue(data[j]);
                Console.WriteLine(vals.Max());
            }
        }
        
        //O(nk) time / O(n) space
        static void MaxVals_Old(List<int> data, int k)
        {
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j <= data.Count; j++)
                {
                    data[j] = Math.Max(data[j], data[j + 1]);
                    if(i == k-1)
                    {
                        Console.WriteLine(data[j]);
                    }
                }
                data.Remove(data.Count - 1);
            }
        }
    }
}
