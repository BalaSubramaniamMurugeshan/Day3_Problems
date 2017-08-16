using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_IandI_Third_Employee
{
    class Person
    {
        public int Age;
        public String Name;
        public String Gender;
    }
    class Employee : Person
    {
        public int EmployeeCode;
        public Employee()
        {
        }
        public void EnterEmployeeDetails()
        {
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Gender : ");
            Gender = Console.ReadLine();
            Console.Write("Enter Employee Code : ");
            EmployeeCode = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Name : "+this.Name);
            Console.WriteLine("Age : "+ this.Age);
            Console.WriteLine("Gender : " + this.Gender);
            Console.WriteLine("Employee Code : " + this.EmployeeCode);
        }
    }
    class Specialist : Employee
    {
        public int SpecialistCode;
        
        public void EnterSpecialistDetails()
        {
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Gender : ");
            Gender = Console.ReadLine();
            Console.Write("Enter Specialist Code : ");
            SpecialistCode = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("Age : " + this.Age);
            Console.WriteLine("Gender : " + this.Gender);
            Console.WriteLine("Specialist Code : " + this.SpecialistCode);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            Specialist[] spe = new Specialist[3];

            for(int i=0;i<3;i++)
            {
                emp[i] = new Employee();
                Console.WriteLine("Enter Employee " + ( i + 1 ) + " Details");
                emp[i].EnterEmployeeDetails();
            }
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                spe[i] = new Specialist();
                Console.WriteLine("Enter Specialist " + ( i + 1 ) + " Details");
                spe[i].EnterSpecialistDetails();
            }
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Employee " + (i + 1) + " Details");
                emp[i].Display();
            }
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Specialist " + (i + 1) + " Details");
                spe[i].Display();
            }

            Console.ReadKey();
        }
    }
}
