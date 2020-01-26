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

            Llist.AddLast("ahoj");
            Llist.AddLast("Jak se máš?");

            //Nejsou seøazeny

            Console.WriteLine("\n---hashset---");

            HashSet<string> Hashset = new HashSet<string>();

            Hashset.Add("Ahoj");
            Hashset.Add("Jak se máš?");

            //Nejsou seøazeny
            Console.WriteLine("\n---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();

            //Nejsou seøazeny

            Console.WriteLine("\n---Sortedset---");

            SortedSet<string> Sset = new SortedSet<string>();

            //øazeno abecednì

            Console.WriteLine("\n---Dictionary---");


            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1,"ahoj");
            dictionary.Add(2, "Jak se máš?");

            //Nejsou øazeny
            Console.WriteLine("\n---ConcurrentDictionary---");

            ConcurrentDictionary<int, string> Cdictionary = new ConcurrentDictionary<int, string>();

            //neøazeno

            Console.WriteLine("\n---SortedDictionary---");

            SortedDictionary<int, string> sDictionary = new SortedDictionary<int, string>();

            sDictionary.Add(2, "Ahoj");
            sDictionary.Add(1, "Jak se máš?");

            foreach (KeyValuePair<int, string> s in sDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    s.Key, s.Value);
            }

            // øazeno podle klíèe

            Console.WriteLine("\n---Queue---");

            Queue<string> queue = new Queue<string>();

            //neøazeno
    
            Console.WriteLine("\n---Stack---");

            Stack stack = new Stack();

            //neøazeno


        }
    }
}
