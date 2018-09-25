using System;

namespace P0012
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3};
            int x = StairClimbDynamic(4, a);
            System.Console.WriteLine(x);
        }

        static int StairClimb_1_2(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            return StairClimb_1_2(n - 1) + StairClimb_1_2(n - 2);
        }

        static int StairClimbDynamic(int n, int[] x)
        {
            if(n < 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            int r = 0;
            for(int i = 0; i < x.Length; i++)
            {
                r += StairClimbDynamic(n - x[i], x);
            }
            return r;
        }
    }
}
