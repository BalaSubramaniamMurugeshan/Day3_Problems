using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eight_SwapNumbers
{
    class Program
    {

        static void SwapNumbers(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers : ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swap Number 1 : {0} Number 2 : {1}",num1,num2);
            SwapNumbers(ref num1,ref num2);
            Console.WriteLine("After  Swap Number 1 : {0} Number 2 : {1}", num1, num2);
            Console.ReadKey();
        }
    }
}
