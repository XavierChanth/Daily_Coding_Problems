using System;

namespace P0016
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderLog ol = new OrderLog();
            ol.Record("pol");
            ol.Record("olp");
            Console.WriteLine(ol.GetLast(1));
            Console.WriteLine(ol.GetLast(2));
        }
    }
}
