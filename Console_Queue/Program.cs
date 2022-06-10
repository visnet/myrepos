using System;
using System.Collections;

namespace Console_Queue
{
    class Program
    {
        //Queue follows the first in first out data structure and it is the collection of objects that uses enqueue and deque method for add and removing items.
        static void Main(string[] args)
        {
            Queue items = new Queue();
            items.Enqueue("Mobile");
            items.Enqueue('A');
            items.Enqueue(20);
            items.Enqueue(false);
            items.Enqueue(5.3f);

            Console.WriteLine("Items is queue......");
            foreach (var data in items)
                Console.WriteLine(data);
            
            var x=items.Dequeue();
            Console.WriteLine("Removing items in queue....." + x); ;
            foreach (var data in items)
                Console.WriteLine(data);

            var info = "Mobile";
            Console.WriteLine("The type of info is {0} ", info.GetType());


            Console.WriteLine("Hello World!");
        }
    }
}
