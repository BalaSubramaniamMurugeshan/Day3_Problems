using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_IandI_One
{
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle Started .....!");
        }
    }
    class Car : Vehicle
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.Start();
            Console.ReadKey();
        }
    }
}
