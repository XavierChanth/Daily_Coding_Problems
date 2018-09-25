using System;
using System.Collections;

namespace P0016
{
    class OrderLog
    {
        static Hashtable orders = new Hashtable();

        public void Record(string id)
        {
            orders.Add(orders.Count, id);
        }
        
        public string GetLast(int i)
        {
            int key = orders.Count - i;
            return orders[key].ToString();
        }
    }
}
