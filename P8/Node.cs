namespace P0008
{
    class Node
    {
        public int Val { get; set; } = 0;
        public Node Left { get; set; } = null;
        public Node Right { get; set; } = null;

        public Node(int val, Node left, Node right)
        {
            Val = val;
            Left = left;
            Right = right;
        }
        public Node(int val, Node left)
        {
            Val = val;
            Left = left;
        }
        public Node(int val)
        {
            Val = val;
        }
        public Node(Node left, Node right)
        {
            Left = left;
            Right = right;
        }
        public Node(Node left)
        {
            Left = left;
        }


    }
}
