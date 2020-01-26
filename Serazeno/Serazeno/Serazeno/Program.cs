using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections;

namespace Serazeno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---List---");

            List<string> list = new List<string>();
            list.Add("string2");
            list.Add("string1");
            list.Add("ahoj");

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            list.Sort();

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            // hodnoty se pomocí .sort uloží abecednì

            Console.WriteLine("\n---LinkedList---");

            LinkedList<string> Llist = new LinkedList<string>();

            Console.WriteLine("\n---hashset---");

            HashSet<string> Hashset = new HashSet<string>();

            Console.WriteLine("\n---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();

            Console.WriteLine("\n---Sortedset---");

            SortedSet<string> Sset = new SortedSet<string>();

            Console.WriteLine("\n---Dictionary---");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

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
