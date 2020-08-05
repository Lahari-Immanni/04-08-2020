using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            Console.WriteLine("adding elements at the last of dictionary");
            foreach (var r in list)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("adding elements at the starting of dictionary");
            list.AddFirst(0);
            foreach (var r in list)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("adding elements before the specified element");
            list.AddAfter(list.Find(5), 6);
            foreach (var r in list)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("adding elements after the specified element");
            list.AddBefore(list.Find(6), 5);
            foreach (var r in list)
            {
                Console.WriteLine(r);
            }
            Console.Read();
        }
    }
}
