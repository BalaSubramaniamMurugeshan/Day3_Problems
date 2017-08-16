using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Thirteen_StructureProgram
{
    struct Student
    {
        String Name,Dob;
        int TotalMarks;
        public Student(String name,String dob,int totalMarks)
        {
            Name = name;
            Dob = dob;
            TotalMarks = totalMarks;
        }
        public void Display()
        {
            Console.WriteLine("Student Details");
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Date of Birth : "+Dob);
            Console.WriteLine("Total marks : "+TotalMarks);
        }
    }
    struct MailingList
    {
        String Name, DoorNo, Street, City;
        int Pincode;
        public MailingList(String name,String doorNo, String street,String city,int pincode)
        {
            Name = name;
            DoorNo = doorNo;
            Street = street;
            City = city;
            Pincode = pincode;
        }
        public void Display()
        {
            Console.WriteLine("Mailing Details");
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Door No : "+DoorNo);
            Console.WriteLine("Street : "+Street);
            Console.WriteLine("City : "+City);
            Console.WriteLine("Pincode : "+Pincode);
        }
    }
    struct Inventory
    {
        String ItemCode, ItemName;
        int Cost, TotalItems;
        public Inventory(String itemCode,String itemName,int cost,int totalItems)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            Cost = cost;
            TotalItems = totalItems;
        }
        public void Display()
        {
            Console.WriteLine("Inventory Details");
            Console.WriteLine("ItemCode : "+ItemCode);
            Console.WriteLine("ItemName : "+ItemName);
            Console.WriteLine("Cost : "+Cost);
            Console.WriteLine("Total Items : "+TotalItems);
        }
    }
    struct Book
    {
        String Author, Title;
        int YearOfPublication, Cost;
        public Book(String author,String title,int yearOfPublication,int cost)
        {
            Author = author;
            Title = title;
            YearOfPublication = yearOfPublication;
            Cost = cost;
        }
        public void Display()
        {
            Console.WriteLine("Book Details");
            Console.WriteLine("Author : "+Author);
            Console.WriteLine("Title : "+Title);
            Console.WriteLine("Year of Publication : "+YearOfPublication);
            Console.WriteLine("Cost : "+Cost);
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
                Console.WriteLine("Menu");
                Console.WriteLine("1) Student Record");
                Console.WriteLine("2) Mailing List");
                Console.WriteLine("3) Inventory List");
                Console.WriteLine("4) Book Record");
                Console.Write("Enter your choice : ");
                int Choice = int.Parse(Console.ReadLine());
                switch(Choice)
                {
                    case 1:
                        {
                            Console.Write("Enter student Name : ");
                            String Name = Console.ReadLine();
                            Console.Write("Enter Date of Birth : ");
                            String Dob = Console.ReadLine();
                            Console.Write("Enter Total marks : ");
                            int Marks = int.Parse(Console.ReadLine());
                            Student obj = new Student(Name, Dob, Marks);
                            obj.Display();
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Enter Name : ");
                            String Name = Console.ReadLine();
                            Console.Write("Enter Door Number : ");
                            String DoorNumber = Console.ReadLine();
                            Console.Write("Enter Street : ");
                            String Street = Console.ReadLine();
                            Console.Write("Enter City : ");
                            String City = Console.ReadLine();
                            Console.Write("Enter PinCode : ");
                            int Pincode = int.Parse(Console.ReadLine());
                            MailingList obj = new MailingList(Name,DoorNumber,Street,City,Pincode);
                            obj.Display();
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Enter Item Code : ");
                            String Itemcode = Console.ReadLine();
                            Console.Write("Enter Item Name : ");
                            String Itemname = Console.ReadLine();
                            Console.Write("Enter Cost : ");
                            int Cost = int.Parse(Console.ReadLine());
                            Console.Write("Enter Total Items : ");
                            int Pincode = int.Parse(Console.ReadLine());
                            Inventory obj = new Inventory(Itemcode,Itemname,Cost,Pincode);
                            obj.Display();
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Enter Author Name : ");
                            String Author = Console.ReadLine();
                            Console.Write("Enter Title : ");
                            String Title = Console.ReadLine();
                            Console.Write("Enter Year of Publication : ");
                            int YearOfPublication = int.Parse(Console.ReadLine());
                            Console.Write("Enter Cost : ");
                            int Cost = int.Parse(Console.ReadLine());
                            Book obj = new Book(Author,Title,YearOfPublication,Cost);
                            obj.Display();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Selection ...!");
                        break;
                }
                Console.Write("Do you want to perform any other operation (y/n) : ");
                decision = Console.ReadKey().KeyChar;
            } while (decision=='y');
        }
    }
}
