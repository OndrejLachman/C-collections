using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int>list = new List<int>();
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            HashSet<int> Hashset = new HashSet<int>();
            SortedSet<int> Sset = new SortedSet<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            ConcurrentDictionary<int, int> Cdictionary = new ConcurrentDictionary<int, int>();
            SortedDictionary<int, int> sDictionary = new SortedDictionary<int, int>();
            Queue<int> queue = new Queue<int>();
            Stack stack = new Stack();

            Thread t1 = new Thread(Vypis);
            Thread t2 = new Thread(Vypis2);

            t1.Start();
            t2.Start();

            void Vypis()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("thread 1 " + i);
                    list.Add(i);
                    bag.Add(i);
                    Hashset.Add(i);
                    //Sset.Add(i);
                    dictionary.Add(i, i);
                    Cdictionary.TryAdd(i, i);
                    sDictionary.Add(i, i);
                    queue.Enqueue(i);
                    stack.Push(i);

                }
            }

            void Vypis2()
            {
                for (int i = 10; i < 20; i++)
                {
                    Console.WriteLine("thread 2 " + i);
                    list.Add(i);
                    bag.Add(i);
                    Hashset.Add(i);
                    //Sset.Add(i);
                    dictionary.Add(i, i);
                    Cdictionary.TryAdd(i, i);
                    sDictionary.Add(i, i);
                    queue.Enqueue(i);
                    stack.Push(i);
                }
            }

            t1.Join();
            t2.Join();


            Console.WriteLine("---List---");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            


            Console.WriteLine("---Cbag---");

            foreach (int i in bag)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---Hashet---");

            foreach (int i in Hashset)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---Dictionary---");

            foreach (KeyValuePair<int, int> i in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    i.Key, i.Value);
            }

            Console.WriteLine("---ConcurentDictionary---");

            foreach (KeyValuePair<int, int> i in Cdictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    i.Key, i.Value);
            }

            Console.WriteLine("---Queue---");

            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---Stack---");

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            



        }
    }
}
