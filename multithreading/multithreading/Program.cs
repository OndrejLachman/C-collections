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
            ConcurrentBag<int> bag2 = new ConcurrentBag<int>();

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
                }
            }

            void Vypis2()
            {
                for (int i = 10; i < 20; i++)
                {
                    Console.WriteLine("thread 2 " + i);
                    list.Add(i);
                    bag.Add(i);
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


        }
    }
}
