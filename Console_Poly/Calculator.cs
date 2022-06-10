using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Poly
{

    //Function Overloading with static polymorpshism
    //Defining two or more functions in a class with same name and each function differ in its function signature

    //The data types of parameters,Order of parameters,Number of parameters
    class Calculator
    {
        public int Max(int num1,int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
        public float Max(float num1,float num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
    }
}
