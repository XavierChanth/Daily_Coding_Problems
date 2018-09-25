namespace P0003
{
    class Node
    {
        public string Val { get; set; } = "";
        public Node Left { get; set; } = null;
        public Node Right { get; set; } = null;
        
        public Node(string val, Node left, Node right)
        {
            Val = val;
            Left = left;
            Right = right;
        }
        public Node(string val, Node left)
        {
            Val = val;
            Left = left;
        }
        public Node(string val)
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
