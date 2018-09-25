namespace P0005
{
    class Pair
    {
        dynamic A { get; set; }
        dynamic B { get; set; }
        public Pair(dynamic a, dynamic b)
        {
            A = a;
            B = b;
        }
        
        public dynamic Car()
        {
            return A;
        }
        public dynamic Cdr()
        {
            return B;
        }
    }
}
