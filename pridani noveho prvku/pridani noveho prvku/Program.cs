using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections;

namespace pridani_noveho_prvku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---ArrayList---");

            ArrayList Alist = new ArrayList();
            Alist.Add("Jedna");
            Alist.Add("Dva");
            Alist.Add("Tři");

            foreach (string s in Alist)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---LinkedList");
 
            LinkedList<string> Llist = new LinkedList<string>();
            Llist.AddFirst("První");
            Llist.AddLast("Poslední");
            Llist.AddFirst("Nový první"); 
            Llist.AddLast("Nový poslední"); 

            foreach (string s in Llist)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---HashSet---");

            HashSet<string> Hashset = new HashSet<string>();
            Hashset.Add("První");
            Hashset.Add("Druhý");
            Hashset.Add("Třetí");

            foreach (string s in Hashset)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("---ConcurrentBag---");

            ConcurrentBag<string> cBag = new ConcurrentBag<string>();
            cBag.Add("První");
            cBag.Add("Druhý");
            cBag.Add("Třetí");

            //vypisuje obráceně -> Třetí, Druhý, První

            foreach (string s in cBag)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---SortedSet---");

            SortedSet<string> Sset = new SortedSet<string>();
            Sset.Add("První");
            Sset.Add("Druhý");
            Sset.Add("Třetí");
            Sset.Add("Čtvrtý");
            Sset.Add("Pátý");

            //vypisuje abecedně

            foreach (string s in Sset)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---Dictionary---");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("1", "první");
            dictionary.Add("2", "druhý");
            dictionary.Add("3", "třetí");

            foreach (KeyValuePair<string, string> s in dictionary)
            {
                Console.WriteLine("klíč : " + s.Key);
                Console.WriteLine("hodnota : " + s.Value);
            }

            Console.WriteLine("\n---ConcurrentDictionary---");

            ConcurrentDictionary<int, string> Cdictionary = new ConcurrentDictionary<int, string>();

            Cdictionary.TryAdd(1, "první");
            Cdictionary.TryAdd(2, "druhý");
            Cdictionary.TryAdd(3, "třetí");
            Cdictionary.TryAdd(4, "Ahoj");
            Cdictionary.TryAdd(0, "Test");

            foreach (KeyValuePair<int, string> s in Cdictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    s.Key, s.Value);
            }

            Console.WriteLine("\n---SortedDictionary---");

            SortedDictionary<int, string> sDictionary = new SortedDictionary<int, string>();

            sDictionary.Add(1, "První");
            sDictionary.Add(3, "Druhý");
            sDictionary.Add(2, "Třetí");

            foreach (KeyValuePair<int, string> s in sDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    s.Key, s.Value);
            }

            //řadí podle klíče

            Console.WriteLine("\n---Queue---");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("První");
            queue.Enqueue("Druhý");
            queue.Enqueue("Třetí");

            foreach (string s in queue)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---Stack---");

            Stack stack = new Stack();

            stack.Push("První");
            stack.Push("Druhý");
            stack.Push("Třetí");
            stack.Push("1");

            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }

            //Last in first out 
        }
    }
}
