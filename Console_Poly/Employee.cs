using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Poly
{
    //When you have a function defined in a class which you want to allow to be implemented by the inherited class, we can use virtual function.
    //Virtual function allows you to re-define itself in inherited class.

    class Employee
    {
        public Employee()
        {
            Console.WriteLine("I am base constructor");
        }
        public void show()
        {
            Console.WriteLine("I am function");
        }
        public virtual int getSalary(int sal)
        {
            return sal;
        }
    }
    class Manager:Employee //Parent is employee class and Manager is child class
    {
        int incentive = 2000;
        public Manager():base()
        {

        }
        public override int getSalary(int sal)
        {
            return sal + incentive;
        }
        public void display()
        {
            
            base.show();
        }
        
    }
    class implement
    {
        public void callFunction(Employee emp) //Object of Employee class
        {
            Console.WriteLine("Manager Total Salary is {0} ",emp.getSalary(5000));
        }
    }
}
