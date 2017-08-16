using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixth_LargestOf3Numbers
{
    class Program
    {
        int LargestOfThreeNumbers(int num1,int num2,int num3)
        {
            if (num1 > num2 && num1 > num3)
                return num1;
            else if (num2 > num1 && num2 > num3)
                return num2;
            else
                return num3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Program obj = new Program();
            int LargeNum = obj.LargestOfThreeNumbers(num1, num2, num3);
            Console.WriteLine("Largest of three numbers is : {0}",LargeNum);
            Console.ReadKey();
        }
    }
}
