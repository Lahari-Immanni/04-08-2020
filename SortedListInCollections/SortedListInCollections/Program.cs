using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListInCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sort = new SortedList<int, string>();
            sort.Add(1, "one");
            sort.Add(2, "two");
            sort.Add(3, "three");
            sort.Add(4, "Four");
            sort.Add(5, "five");
            sort.Add(6, "six");
            sort.Add(7, "seven");
            foreach (var i in sort)
            {
                Console.WriteLine("{0}={1}", i.Key, i.Value);
            }
            Console.WriteLine(sort.Count());

            Console.WriteLine(sort.ContainsKey(8));
            Console.WriteLine(sort.ContainsValue("eight"));
            Console.WriteLine(sort.ContainsKey(7));
            Console.WriteLine(sort.ContainsValue("five"));
            Console.Read();

        }
    }
}
