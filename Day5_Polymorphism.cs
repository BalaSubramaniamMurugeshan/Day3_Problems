using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Polymorphism
{
    interface Person
    {
        void getDescription();
    }
    class Student : Person
    {
        protected String StudentName, Email;
        protected char Grade;
        public void StudentDetails(String name,String email)
        {
            StudentName = name;
            Email = email;
        }
        public void GetGrade(char grade)
        {
            Grade = grade;
        }
        public void getDescription()
        {
            Console.WriteLine(StudentName+" is a {0} Grade Student .",Grade);
        }
    } 
    class Lecturer : Person
    {
        protected String Subject;
        public void GetSubject(String subject)
        {
            Subject = subject;
        }
        public void getDescription()
        {
            Console.WriteLine("Teacher teaches {0} .", Subject);
        }
    }
    class Employee : Person
    {
        protected String Department;
        public void GetDepartment(String department)
        {
            Department = department;
        }
        public void getDescription()
        {
            Console.WriteLine("Employee works in {0} .", Department);
        }
    }
    class PersonViewerTest
    {
        
        static void Main(string[] args)
        {
            Student StudentObj = new Student();
            Lecturer LecturerObj = new Lecturer();
            Employee EmployeeObj = new Employee();

            PersonViewerTest obj = new PersonViewerTest();

            Console.Write("Enter Student Name : ");
            String Name = Console.ReadLine();
            Console.Write("Enter e-mail Id : ");
            String Email = Console.ReadLine();
            StudentObj.StudentDetails(Name,Email);
            Console.Write("Enter grade of the Student : ");
            char Grade = Console.ReadKey().KeyChar;
            StudentObj.GetGrade(Grade);
            StudentObj.getDescription();

            Console.Write("Enter the Subject that Teacher teaches :");
            String Subject = Console.ReadLine();
            LecturerObj.GetSubject(Subject);
            LecturerObj.getDescription();

            Console.Write("Enter the Department that Employee Works :");
            String Department = Console.ReadLine();
            EmployeeObj.GetDepartment(Department);
            EmployeeObj.getDescription();

            Console.ReadKey();

        }
    }
}
