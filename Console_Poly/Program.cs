using System;

namespace Console_Poly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calculator calc = new Calculator();
            Console.WriteLine("Max number is "+calc.Max(4, 3));
            Console.WriteLine("Max number is {0} ", calc.Max(5.4f, 8.6f));

            Console.WriteLine("Operator Overloading..................................");

            BinaryOverload obj1 = new BinaryOverload(5);
            BinaryOverload obj2 = new BinaryOverload(7);
            BinaryOverload obj3 = new BinaryOverload();
            obj3 = obj1 + obj2;
            obj3.show();

            Console.WriteLine("Virtual Function Demo..............");
            implement imp = new implement();
            Manager manager = new Manager();

            imp.callFunction(manager);


        }
    }
}
