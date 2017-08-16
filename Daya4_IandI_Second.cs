using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daya4_IandI_Second
{
    class Animal
    {
        public String Name;
        public int Age;
        public void Display()
        {
            Console.Write(Name);
            Console.Write(" he is "+Age+" years old .");
        }
    }
    class Cat : Animal
    {
        public Cat(String name,int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Dog : Animal
    {
        public Dog(String name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat Cobj = new Cat("Cat : Sanjay",7);
            Dog Dobj = new Dog("Dog : Jack",8);
            Cobj.Display();
            Console.WriteLine();
            Dobj.Display();
            Console.ReadKey();
        }
    }
}
