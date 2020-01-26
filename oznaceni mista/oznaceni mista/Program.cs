using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;

namespace oznaceni_mista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---List---");

            List<string> list = new List<string>();

            list.Add("první");
            list.Add("druhý");

            Console.WriteLine(list[1]);

            //používá indexy

            Console.WriteLine("\n---LinkedList---");

            LinkedList<string> Llist = new LinkedList<string>();

            Llist.AddFirst("první");
            Llist.AddLast("druhý");

            //indexuje 

            Console.WriteLine(Llist.ElementAt(0));

            Console.WriteLine("\n---hashset---");

            HashSet<string> Hashset = new HashSet<string>();

            Hashset.Add("první");
            Hashset.Add("druhý");

            Console.WriteLine(Hashset.ElementAt(0));

            //indexuje 
            // není to správné, hashset těží právě z hashe, výhody ztrácí při použití indexu

            Console.WriteLine("\n---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();

            cBag.Add("první");
            cBag.Add("druhý");

            Console.WriteLine(cBag.ElementAt(1));

            //indexuje 

            Console.WriteLine("\n---Sortedset---");

            SortedSet<string> Sset = new SortedSet<string>();

            Sset.Add("první");
            Sset.Add("druhý");

            Console.WriteLine(Sset.ElementAt(1));
            
            //indexuje 

            Console.WriteLine("\n---Dictionary---");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            Console.WriteLine("\n---ConcurrentDictionary---");

            ConcurrentDictionary<int, string> Cdictionary = new ConcurrentDictionary<int, string>();

            Console.WriteLine("\n---SortedDictionary---");

            SortedDictionary<int, string> sDictionary = new SortedDictionary<int, string>();

            Console.WriteLine("\n---Queue---");

            Queue<string> queue = new Queue<string>();

            Console.WriteLine("\n---Stack---");

            Stack stack = new Stack();
        }
    }
}
