using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;

namespace pridani_prvku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---List---");

            List<string> list = new List<string>();

            list.Add("test");

           //metoda add

            Console.WriteLine("\n---LinkedList---");

            LinkedList<string> Llist = new LinkedList<string>();

            /*
            Llist.AddAfter();
            Llist.AddBefore();
            Llist.AddFirst();
            Llist.AddLast();
            */

            Console.WriteLine("\n---hashset---");

            HashSet<string> Hashset = new HashSet<string>();

            //Hashset.Add(); 

            Console.WriteLine("\n---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();

            //cBag.Add();

            Console.WriteLine("\n---Sortedset---");

            SortedSet<string> Sset = new SortedSet<string>();

            //Sset.Add();

            Console.WriteLine("\n---Dictionary---");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            //dictionary.Add();

            Console.WriteLine("\n---ConcurrentDictionary---");

            ConcurrentDictionary<int, string> Cdictionary = new ConcurrentDictionary<int, string>();

            //Cdictionary.TryAdd();

            Console.WriteLine("\n---SortedDictionary---");

            SortedDictionary<int, string> sDictionary = new SortedDictionary<int, string>();

            //sDictionary.Add();

            Console.WriteLine("\n---Queue---");

            Queue<string> queue = new Queue<string>();

            //queue.Enqueue();

            Console.WriteLine("\n---Stack---");

            Stack stack = new Stack();

            //stack.Push();
        }
    }
}
