using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenth_StaticVariableForObject
{
    class Program 
    {
        static int ObjCount = 0;
        Program()
        {
            ObjCount++;
        }
        static void Main(string[] args)
        {
            Program Obj1 = new Program();
            Console.WriteLine("Number of Objects currently existing for a class is {0}", ObjCount);
            Program Obj2 = new Program();
            Console.WriteLine("Number of Objects currently existing for a class is {0}", ObjCount);
            Program Obj3 = new Program();
            Console.WriteLine("Number of Objects currently existing for a class is {0}", ObjCount);
            Console.ReadKey();
        }
    }
}
