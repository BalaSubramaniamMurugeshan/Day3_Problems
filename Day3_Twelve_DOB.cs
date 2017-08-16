using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Twelve_DOB
{
    struct DateOfBirth
    {
        int Date, Month, Year;
        public DateOfBirth(int date, int month, int year)
        {
            Date = date;
            Month = month;
            Year = year;
        }
        public void Display()
        {
            Console.WriteLine("My Date Of Birth is {0}/{1}/{2}",Date,Month,Year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Date : ");
            int date = int.Parse(Console.ReadLine());
            Console.Write("Enter Month : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter Year : ");
            int year = int.Parse(Console.ReadLine());
            DateOfBirth obj = new DateOfBirth(date,month,year);
            obj.Display();
            Console.ReadKey();
        }
    }
}
