using System;
using System.Collections;

namespace Console_ArrayList
{

    //Collections classes are classes that we use for data storage and data access. We can add objects to the collection. It also allows you to store
    //heterogenous types of data. it is dynamic type and also it allocates memory dynamically as when required.

   
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList scores = new ArrayList();
            scores.Add(30);
            scores.Add(20);
            scores.Add(40);
            scores.Add(50);
            Console.WriteLine("The array list memory capacity {0} ", scores.Capacity);
            Console.WriteLine("The array list values size {0} ", scores.Count);
            foreach (int items in scores)
                Console.WriteLine(items);
            scores.RemoveAt(1);
            foreach (int items in scores)
                Console.WriteLine(items);
            Console.WriteLine("The array list memory capacity {0} ", scores.Capacity);
            Console.WriteLine("The array list values size {0} ", scores.Count);
            scores.Add(100);
            scores.Add(70);
            scores.Sort();
            if (scores.Contains(101))
                Console.WriteLine("Value found...");
            else
                Console.WriteLine("not found");
            foreach (int items in scores)
                Console.WriteLine(items);





            scores.TrimToSize();

            Console.WriteLine("The array list memory capacity {0} ", scores.Capacity);
            Console.WriteLine("The array list values size {0} ", scores.Count);

            ArrayList data = new ArrayList()
            {
                "Mobile",'A',8,true
            };
            data.Add("computer");
            data.Add("tablets");

            int[] info = { 21, 5, 65 };
            data.AddRange(info);

            foreach (var values in data)
                Console.WriteLine("Values in arraylist {0} at index {1} ",values,data.IndexOf(values));

            ArrayList students = new ArrayList()
            {
                new Student(){id=1001,name="Rahul",marks=90},
                new Student(){id=1002,name="Raj",marks=80},
                new Student(){id=1003,name="Rohit",marks=75}
            };
            students.Add(new Student() { id = 1004, name = "Rohan", marks = 65 });
            foreach (Student studs in students)
                Console.WriteLine("ID {0} Name {1} Marks {2} ", studs.id, studs.name, studs.marks);

         
            Console.WriteLine("Hello World!");
        }
    }
}




