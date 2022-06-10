using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Poly
{
    //+ operator is overloading and adding two objects of same class BinaryOverload
    class BinaryOverload
    {
        public int number;

        public BinaryOverload()
        {
            number = 0;
        }
        public BinaryOverload(int x)
        {
            number = x;
        }

        //Overloading + Operator
        //operator +()

        public static BinaryOverload operator +(BinaryOverload b1,BinaryOverload b2)
        {
            BinaryOverload b3 = new BinaryOverload(0);
            b3.number = b1.number + b2.number;
            return b3;
        }
        public void show()
        {
            Console.WriteLine("{0} ", number);
        }


    }
}
