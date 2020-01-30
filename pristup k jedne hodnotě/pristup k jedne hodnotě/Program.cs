using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;
namespace pristup_k_jedne_hodnotě
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---List---");

            List<string> list = new List<string>();

            //list.Find();
            //list.FindAll();
            Console.WriteLine("\n---LinkedList---");

            LinkedList<string> Llist = new LinkedList<string>();

            //Llist.Find();
            //Llist.FindLast();

            Console.WriteLine("\n---hashset---");

            HashSet<string> Hashset = new HashSet<string>();

            
            //Hashset.ElementAt();

            Console.WriteLine("\n---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();

            //cBag.ElementAt();

            Console.WriteLine("\n---Sortedset---");

            SortedSet<string> Sset = new SortedSet<string>();

            //Sset.ElementAt();

            Console.WriteLine("\n---Dictionary---");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            //dictionary.TryGetValue();

            Console.WriteLine("\n---ConcurrentDictionary---");

            ConcurrentDictionary<int, string> Cdictionary = new ConcurrentDictionary<int, string>();

            //Cdictionary.TryGetValue();

            Console.WriteLine("\n---SortedDictionary---");

            SortedDictionary<int, string> sDictionary = new SortedDictionary<int, string>();

            //sDictionary.TryGetValue();

            Console.WriteLine("\n---Queue---");

            Queue<string> queue = new Queue<string>();

            //queue.ElementAt();

            Console.WriteLine("\n---Stack---");

            Stack stack = new Stack();

            //nelze přistupovat
        }
    }
}
