using System;

namespace P0010
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionHandler fh = new FunctionHandler(10, "FunctionA");
            fh.CallNewFunction(10, "FunctionA");
        }

        //Test Functions
        public static void FunctionA()
        {
            Console.WriteLine("Function A Executed!");
        }
        public static void FunctionB()
        {
            Console.WriteLine("Function B Executed!!");
        }
        public static void FunctionC()
        {
            Console.WriteLine("Function C Executed!!!");
        }

    }
}
