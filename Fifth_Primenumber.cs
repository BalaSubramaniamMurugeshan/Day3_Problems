using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifth_Primenumber
{
    class Program
    {
        bool Prime(int num)
        {
            for (int i = 2; i < Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            Program obj = new Program();
            bool result=obj.Prime(number);
            if (result)
                Console.WriteLine(number + " is a Prime number .");
            else
                Console.WriteLine(number + " is not a Prime number .");
            Console.ReadKey();
        }
    }
}
