using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;

namespace @null
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---List---");

            List<string> list = new List<string>();

            list.Add(null);

            List<int> list2 = new List<int>();

            list.Add(null);

            //jde přidat

            Console.WriteLine("\n---LinkedList---");

            LinkedList<string> Llist = new LinkedList<string>();

            //Llist.AddFirst(null);
            //nejde

            LinkedList<int> Llist2 = new LinkedList<int>();

            Llist2.AddFirst(null);

            Console.WriteLine("\n---hashset---");

            HashSet<string> Hashset = new HashSet<string>();

            Hashset.Add(null);

            // jde přidat

            Console.WriteLine("\n---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();

            cBag.Add(null);

            // jde

            Console.WriteLine("\n---Sortedset---");

            SortedSet<string> Sset = new SortedSet<string>();

            Sset.Add(null);

            Console.WriteLine("\n---Dictionary---");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, null);
            
            //může byt null

            //dictionary.Add(null, null); 

            //klíč nesmí být null
            Console.WriteLine("\n---ConcurrentDictionary---");

            ConcurrentDictionary<int, string> Cdictionary = new ConcurrentDictionary<int, string>();

            // klíč nesmí být null, data můžou

            Console.WriteLine("\n---SortedDictionary---");

            SortedDictionary<int, string> sDictionary = new SortedDictionary<int, string>();

            sDictionary.Add(1, null);

            // klíč nesmí být null, data můžou

            Console.WriteLine("\n---Queue---");

            Queue<string> queue = new Queue<string>();

            queue.Enqueue(null);

            //může být null

            Console.WriteLine("\n---Stack---");

            Stack stack = new Stack();


            stack.Push(null);

            // může být null
        }
    }
}
