using System;
using System.Collections;

namespace P0011
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "deep", "dog", "dolphin" };
            Array x = GetQueryStrings("do", s).ToArray();
            Console.WriteLine(x.GetValue(0).ToString() + x.GetValue(1).ToString());
        }

        static ArrayList GetQueryStrings(string query, string[] data)
        {
            ArrayList results = new ArrayList();
            if (data.Length == 0)
            {
                return results;
            }
            Array.Sort(data);
            bool previous = false;
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i].Substring(0, query.Length) == query)
                {
                    previous = true;
                    results.Add(data[i]);
                }
                else
                {
                    if(previous == true)
                    {
                        return results;
                    }
                    previous = false;
                }

            }
            return results;

        }
    }
}
