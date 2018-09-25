using System;

namespace P0005
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pair("a", new Pair("b","c"));
            Console.WriteLine(p.Car());
            Console.WriteLine(p.Cdr().Car());
            Console.WriteLine(p.Cdr().Cdr());
        }
    }
}
