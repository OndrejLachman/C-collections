using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;

namespace odebrani_jednoho_prvku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---List---");

            List<string> list = new List<string>();

            //list.Remove();
            //list.RemoveAt();

            Console.WriteLine("\n---LinkedList---");

            LinkedList<string> Llist = new LinkedList<string>();

            //Llist.Remove();
            //Llist.RemoveFirst();
            //Llist.RemoveLast();

            Console.WriteLine("\n---hashset---");

            HashSet<string> Hashset = new HashSet<string>();

            //Hashset.Remove();

            Console.WriteLine("\n---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();

            //cBag.TryTake();

            Console.WriteLine("\n---Sortedset---");

            SortedSet<string> Sset = new SortedSet<string>();

            //Sset.Remove();
            //Sset.RemoveWhere();

            Console.WriteLine("\n---Dictionary---");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            //dictionary.Remove();

            Console.WriteLine("\n---ConcurrentDictionary---");

            ConcurrentDictionary<int, string> Cdictionary = new ConcurrentDictionary<int, string>();

            //Cdictionary.TryRemove();

            Console.WriteLine("\n---SortedDictionary---");

            SortedDictionary<int, string> sDictionary = new SortedDictionary<int, string>();

            //sDictionary.Remove();

            Console.WriteLine("\n---Queue---");

            Queue<string> queue = new Queue<string>();

            //queue.Dequeue();

            Console.WriteLine("\n---Stack---");

            Stack stack = new Stack();

            //stack.Pop();
        }
    }
}
