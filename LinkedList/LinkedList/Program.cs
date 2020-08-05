using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
            foreach(var i in lList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*************************");
            lList.AddFirst("the");
            foreach(var j in lList)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("*************************");
            lList.AddLast("fox");
            foreach(var k in lList)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("*************************");
            lList.AddAfter(lList.Find("quick"), "brown");
            foreach(var k in lList)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("*************************");
            lList.AddBefore(lList.FindLast("the"), "over");
            foreach (var k in lList)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("*************************");
            lList.AddBefore(lList.Find("over"), "jumps");
            foreach (var k in lList)
            {
                Console.WriteLine(k);
            }
        }
    }
}
