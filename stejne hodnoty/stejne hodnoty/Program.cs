using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;

namespace stejne_hodnoty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---List---");

            List<string> list = new List<string>();

            list.Add("test");
            list.Add("test");

            //jde

            Console.WriteLine("\n---LinkedList---");

            LinkedList<string> Llist = new LinkedList<string>();

            Llist.AddFirst("test");
            Llist.AddFirst("test");

            Console.WriteLine("\n---hashset---");

            HashSet<string> Hashset = new HashSet<string>();

            Hashset.Add("test");
            Hashset.Add("test");

            Console.WriteLine("\n---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();

            cBag.Add("test");
            cBag.Add("test");

            Console.WriteLine("\n---Sortedset---");

            SortedSet<string> Sset = new SortedSet<string>();

            Sset.Add("test");
            Sset.Add("test");

            Console.WriteLine("\n---Dictionary---");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "test");
            dictionary.Add(2, "test");

            Console.WriteLine("\n---ConcurrentDictionary---");

            ConcurrentDictionary<int, string> Cdictionary = new ConcurrentDictionary<int, string>();

            Cdictionary.TryAdd(1, "test");
            Cdictionary.TryAdd(1, "test");

            Console.WriteLine("\n---SortedDictionary---");

            SortedDictionary<int, string> sDictionary = new SortedDictionary<int, string>();

            sDictionary.Add(1, "test");
            sDictionary.Add(2, "test");

            Console.WriteLine("\n---Queue---");

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("test");
            queue.Enqueue("test");

            Console.WriteLine("\n---Stack---");

            Stack stack = new Stack();

            stack.Push("test");
            stack.Push("test");
        }
    }
}
