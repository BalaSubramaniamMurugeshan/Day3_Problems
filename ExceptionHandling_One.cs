using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                    Console.WriteLine("Square root of this number is : " + Math.Sqrt(num) + "\nGood Bye ...!");
                else 
                    Console.WriteLine("Invalid Number\nGood Bye ...!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number\nGood Bye ...!");
            }
            Console.ReadKey();
        }
    }
}
