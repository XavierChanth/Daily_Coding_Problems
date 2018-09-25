using System;

namespace P0003
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node("root", new Node("left", new Node("left.left")), new Node("right"));
            string serial = SerializeRoot(node);
            Console.WriteLine(serial);
            Node n = Deserialize(serial);
        }

        static string SerializeRoot(Node data)
        {
            string s = $"{data.Val}*";
            if(data.Left != null)
            {
                s += Serialize(data.Left, "l");
            }
            if(data.Right != null)
            {
                s += Serialize(data.Right,"r");
            }
            return s;
        }
        static string Serialize(Node data, string location)
        {
            string s = $"{location}#{data.Val}*";
            if (data.Left != null)
            {
                s += Serialize(data.Left, $"{location}l");
            }
            if (data.Right != null)
            {
                s += Serialize(data.Right, $"{location}r");
            }
            return s;
        }

        static Node Deserialize(string data)
        {
            string val = data.Substring(0, data.IndexOf('*'));
 
            Node root = new Node(val, Deserialize(data, "l"), Deserialize(data, "r"));
            return root;
        }
        static Node Deserialize(string data, string location)
        {
            if(data.Contains($"{location}#"))
            {
                string temp = data.Substring(data.IndexOf($"{location}#"));
                string val = temp.Substring(temp.IndexOf('#') + 1, temp.IndexOf('*')- temp.IndexOf('#')-1);
                Console.WriteLine(val);
                Node node = new Node(val, Deserialize(data, $"{location}l"), Deserialize(data, $"{location}r"));
                return node;
            }
            return null;
        }
    }
}
