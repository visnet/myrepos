using System;
using System.Collections;
using Console_ArrayList;

namespace Console_Stack
{
    class Program
    {

        static void Main(string[] args)
        {
            Stack data = new Stack();
            data.Push(6);
            data.Push(9);
            data.Push(3);
            Console.WriteLine("The elements in stack........");
            foreach (int items in data)
                Console.WriteLine(items);
            data.Push(12);
            data.Push(15);

            Console.WriteLine("Next element to be popped is {0} ", data.Peek());
            Console.WriteLine("Removing elements from stack.....");
            data.Pop();
            foreach (int items in data)
                Console.WriteLine(items);

            Stack records = new Stack();
            records.Push(new Student() { id = 101, name = "S1", marks = 90 });
            records.Push(new Student() { id = 102, name = "S2", marks = 45 });
            foreach (Student student in records)
                Console.WriteLine("Student ID {0} Name {1} Marks {2} ", student.id, student.name, student.marks);

            Console.WriteLine("Hello World!");
        }
    }
}
