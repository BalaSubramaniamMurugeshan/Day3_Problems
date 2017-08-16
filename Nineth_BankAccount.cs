using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nineth_BankAccount
{
    class BankAccount
    {
        String Nameofdepsitor;
        float Accountno;
        String Typeofaccount;
        static float Balanceamount;

        public BankAccount(String name,float accno,String acctype)
        {
            Nameofdepsitor = name;
            Accountno = accno;
            Typeofaccount = acctype;
            Balanceamount = 0;
        }

        public void Deposit(float Amount)
        {
            Balanceamount += Amount;
            Console.WriteLine("Deposited ...!  Balance : "+Balanceamount);
        }

        public void Withdraw(float Amount)
        {
            if (Amount <= Balanceamount)
            {
                Balanceamount -= Amount;
                Console.WriteLine("Withdrawed amount : "+Amount);
            }
            else
                Console.WriteLine("Insufficient Balance .....!");
        }

        public void Display()
        {
            Console.WriteLine("Name : "+Nameofdepsitor);
            Console.WriteLine("Account No :"+Accountno);
            Console.WriteLine("Balance : "+Balanceamount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter user name : ");
            String name = Console.ReadLine();
            Console.Write("Enter account number : ");
            float accno = float.Parse(Console.ReadLine());
            Console.Write("Enter type of account : ");
            String acctype = Console.ReadLine();

            BankAccount user1 = new BankAccount(name,accno,acctype);
            byte choice;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Deposit");
                Console.WriteLine("2) Withdraw");
                Console.WriteLine("3) display");
                Console.Write("Enter your choice : ");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit : ");
                        float amount = float.Parse(Console.ReadLine());
                        user1.Deposit(amount);
                        break;
                    case 2:
                        Console.Write("Enter amount to withdraw : ");
                        float amt = float.Parse(Console.ReadLine());
                        user1.Withdraw(amt);
                        break;
                    case 3:
                        user1.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection ...!");
                        break;
                }
            } while(choice < 4);
            Console.ReadKey();
        }
    }
}
