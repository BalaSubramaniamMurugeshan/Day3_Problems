using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_SimpleInterest
{
    class Program
    {
        void CalculateFinalValue(float principle,float years,float interest)
        {
            Console.WriteLine("Principle Amount : {0} "
                +"Time Period : {1}years Interest : {2}% Final Amount : {3}",
                principle,years,interest,principle+((principle*years*interest)/100));
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the principle amount : ");
            float principle = int.Parse(Console.ReadLine());
            Console.Write("Enter the no of years : ");
            float years = int.Parse(Console.ReadLine());
            Console.Write("Enter the interest rate : ");
            float interest = int.Parse(Console.ReadLine());
            Program obj = new Program();
            obj.CalculateFinalValue(principle,years,interest);
            Console.ReadKey();
        }
    }
}
