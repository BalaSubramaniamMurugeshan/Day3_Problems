using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleventh_BookInventory
{
    public class Book
    {
        String[] BookAuthor = {"sam", "jhon","aron" };
        String[] BookTitle = {"c#",".net","vb"};
        float[] BookPrice = {123,234,345};
        String[] BookPublisher = {"MCGrill", "MCGrill" , "MCGrill" };
        static int[] BookStock = {10,20,30};

        float price = 0;
        int index = 0;
        int Stock = 0;

        public bool CheckAvailability(String Title,String Author)
        {
            for(int i=0; i<BookTitle.Length;i++)
            {
                if (BookTitle[i].Equals(Title) && BookAuthor[i].Equals(Author) && BookStock[i] > 0)
                {
                    index = i;
                    Stock = BookStock[i];
                    price = BookPrice[i];
                    return true;
                }
            }
            return false;
        }
        public float GetPrice()
        {
            return price;
        }
        public int GetStock()
        {
            return Stock;
        }
        public float StockAvailability(int copies)
        {
            if (copies <= BookStock[index])
            {
                BookStock[index] = BookStock[index] - copies;
                return copies * price;
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char decision = '\0';
            do
            {
                Console.Clear();
                Console.Write("Enter the TITLE of the book : ");
                String Title = Console.ReadLine();
                Console.Write("Enter the AUTHOR of the book : ");
                String Author = Console.ReadLine();
                Book obj = new Book();
                bool Availability = obj.CheckAvailability(Title,Author);
                if (Availability)
                {
                    Console.WriteLine("Book Details : ");
                    Console.WriteLine("Title : "+Title);
                    Console.WriteLine("Author : "+Author);
                    Console.WriteLine("Price : "+obj.GetPrice());
                    //Console.WriteLine("Stock : " + obj.GetStock());
                    Console.WriteLine("Enter the number of copies required : ");
                    int copies = int.Parse(Console.ReadLine());
                    float price = obj.StockAvailability(copies);
                    if (price == 0)
                        Console.WriteLine("Insufficient Stock ...!");
                    else
                    {
                        Console.WriteLine("The total cost of the books is : "+price);
                    }
                }
                else
                    Console.WriteLine("Sorry ...! The book you requested is Not Available .");
                Console.Write("Do you want any other book (y/n) : ");
                decision = Console.ReadKey().KeyChar;
            } while (decision=='y');
        }
    }
}
