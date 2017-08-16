using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Dividend : ");
            int Dividend = int.Parse(Console.ReadLine());
            Console.Write("Enter the Divisior : ");
            int Divisior = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Answer of Division is : "+(Dividend/Divisior));
            }
            catch(Exception e)
            {
                Console.WriteLine("The Divisior should not be Zero");
            }
            Console.ReadKey();
        }
    }
}
