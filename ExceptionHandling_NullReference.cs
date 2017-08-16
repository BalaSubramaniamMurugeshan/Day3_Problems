using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_NullReference
{
    class Bank
    {
        public String BankName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bank obj = null;
                obj.BankName = "SBI";
            }
            catch(Exception e)
            {
                Console.WriteLine("Object reference not set to an instance of an Object.");
            }
            Console.ReadKey();

        }
    }
}
