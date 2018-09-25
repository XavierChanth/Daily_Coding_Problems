using System;

namespace P0007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecodeCount("111"));
        }

        static int DecodeCount(string msg)
        {
            if(msg[0] == '0' || msg.Length == 0)
            {
                return 0;
            }  
            if(msg.Length == 1)
            {
                return 1;
            }
            if(msg[0] == '1' || (msg[0] == '2' && (int)msg[1] <= 6))
            {
                if (msg.Length == 2)
                {
                    return 2;
                }
                return DecodeCount(msg.Substring(1)) + DecodeCount(msg.Substring(2));
            }
            return DecodeCount(msg.Substring(1));
            
        }
    }
}
