using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLine_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.PrintLine(20);
            Console.ReadKey();
        }

        private void PrintLine(int v)
        {
            PrintLine(20);
            Console.ReadKey();
        }
    }
}
