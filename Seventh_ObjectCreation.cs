using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh_ObjectCreation
{

    class Sample
    {
        static int ObjCount = 0;
        public Sample()
        {
            Console.WriteLine("Object " + (++ObjCount) + " Created .");
        }
        ~Sample()
        {
            Console.WriteLine("Object " + (--ObjCount) + " Destroyed .");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj1 = new Sample();
            Sample obj2 = new Sample();
            Sample obj3 = new Sample();
            Console.ReadKey();
        }
    }
}
