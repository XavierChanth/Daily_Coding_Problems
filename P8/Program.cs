using System;

namespace P0008
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(new Node(1), new Node(0, new Node(1, new Node(1), new Node(1)), new Node(0)));
            Console.WriteLine(CountUnivalSubtrees(n));
        }

        static int CountUnivalSubtrees(Node node)
        {
            int x = 0;
            if(node.Left != null)
            {
                x += CountUnivalSubtrees(node.Left);
            }
            if(node.Right != null)
            {
                x += CountUnivalSubtrees(node.Right);
            }
            if((node.Left == null || node.Left.Val == node.Val) && (node.Right == null || node.Right.Val == node.Val))
            {
                return 1 + x;
            }
            return x;
        }
    }
}
