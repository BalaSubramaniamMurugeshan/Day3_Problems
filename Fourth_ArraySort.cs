using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_ArraySort
{
    class Program
    {
        void Sort(int []arr)
        {
            Array.Sort(arr);
            Console.WriteLine("Sorted Array ");
            for (int i=0;i<arr.Length;i++)
                Console.WriteLine(arr[i]);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the array size : ");
            int size = int.Parse(Console.ReadLine());
            int []arr = new int[size];
            Console.WriteLine("Enter array elements");
            for(int i = 0;i < size;i++)
                 arr[i] = int.Parse(Console.ReadLine());
            Program obj = new Program();
            obj.Sort(arr);
            Console.ReadKey();
        }
    }
}
