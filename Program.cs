using System;

namespace Heirarchical_Inheritance
{
    class BaseClass
    {
        public void hello()
        {
            Console.WriteLine("Parent's Hello Method");
        }
    }
    class ChildClass : BaseClass
    {
        public void World()
        {
            Console.WriteLine("Child's World Method");
        }
    }
    class SecondChildClass : BaseClass
    {
        public void Hi()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass c1 = new ChildClass();
            SecondChildClass c2 = new SecondChildClass();
            c1.hello();
            c1.World();
            c2.hello();
            c2.Hi();
        }
    }
}
