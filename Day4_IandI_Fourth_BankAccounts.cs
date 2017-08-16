using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_IandI_Fourth_BankAccounts
{
    class Account
    {
        protected static String CustomerName,AccountNumber;
        protected static char AccountType;
        protected static double Balance;
        public Account()
        {
            Balance = 0;
        }
        public Account(String customerName,String accountNumber,char accountType)
        {
            CustomerName = customerName;
            AccountNumber = accountNumber;
            AccountType = accountType;
        }
    }
    class SavingsAccount : Account
    {
        public void Deposit(double amount)
        {
            Balance += amount;
            CompoundInterest(amount);
            DisplayBalance();
        }
        void DisplayBalance()
        {
            Console.WriteLine("Your Balance is Rs." + Balance);
        }
        void CompoundInterest(double amount)
        {
            Console.Write("Enter the number years to calculate compound interest : ");
            double Years = double.Parse(Console.ReadLine());
            double CompoundInterest = (amount + Math.Pow(( 1 + (0.05/100)),Years));
            Console.WriteLine("Your Interest amount is Rs."+CompoundInterest);
            Balance += CompoundInterest;
        } 
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                DisplayBalance();
            }
            else
                Console.WriteLine("Insufficient Balance ...!");
        }
        public void Display()
        {
            Console.WriteLine("Account Holder Details");
            Console.WriteLine("Customer Name : "+CustomerName);
            Console.WriteLine("Account Number : "+AccountNumber);
            Console.WriteLine("Account Type : Savings");
            Console.WriteLine("Balance : "+Balance);
        }
    }
    class CurrentAccount : Account
    {
        double MinimumBalance = 500;
        public void Deposit(double amount)
        {
            Balance += amount;
            DisplayBalance();
        }
        void DisplayBalance()
        {
            Console.WriteLine("Your Balance is Rs."+Balance);
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                DisplayBalance();
                CheckMinimumBalance();
            }
            else
                Console.WriteLine("Insufficient Balance ...!");
        }
        void CheckMinimumBalance()
        {
            if (Balance <= MinimumBalance)
            {
                Console.WriteLine("Your are imposed penalty of Rs.100 for crossing below Minimum Balance.");
                Balance -= 100;
                if (Balance > 0)
                    DisplayBalance();
            }
        }
        public void Display()
        {
            Console.WriteLine("Account Holder Details");
            Console.WriteLine("Customer Name : " + CustomerName);
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Type : Current");
            Console.WriteLine("Balance : " + Balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            String CustomerName = Console.ReadLine();
            Console.Write("Enter Account Number : ");
            String AccountNo = Console.ReadLine();
            Console.Write("Enter Type of Account (s/c) : ");
            Char AccountType = Console.ReadKey().KeyChar;
            Account account = new Account(CustomerName,AccountNo,AccountType);
            Console.Clear();
            if (AccountType == 's')
            {

                SavingsAccount obj = new SavingsAccount();
                char decision = '\0';
                do
                {
                    Console.Clear();
                    Console.WriteLine("Menu");
                    Console.WriteLine("1) Deposit");
                    Console.WriteLine("2) Withdraw");
                    Console.WriteLine("3) Mini Statement");
                    Console.Write("Enter your choice : ");
                    int choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            {
                                Console.Write("Enter the Amount to deposit : ");
                                double amount = double.Parse(Console.ReadLine());
                                obj.Deposit(amount);
                            }
                            break;
                        case 2:
                            {
                                Console.Write("Enter the Amount to withdraw : ");
                                double amount = double.Parse(Console.ReadLine());
                                obj.Withdraw(amount);
                            }
                            break;
                        case 3:
                            obj.Display();
                            break;
                        default:
                            Console.WriteLine("Invalid Option ...!");
                            break;
                    }
                    Console.Write("Do you wish to perform another Transaction (y/n) : ");
                    decision = Console.ReadKey().KeyChar;
                } while (decision == 'y');
            }
            else if (AccountType == 'c')
            {
                CurrentAccount obj = new CurrentAccount();
                char decision = '\0';
                do
                {
                    Console.Clear();
                    Console.WriteLine("Menu");
                    Console.WriteLine("1) Deposit");
                    Console.WriteLine("2) Withdraw");
                    Console.WriteLine("3) Mini Statement");
                    Console.Write("Enter your choice : ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Enter the Amount to deposit : ");
                                double amount = double.Parse(Console.ReadLine());
                                obj.Deposit(amount);
                            }
                            break;
                        case 2:
                            {
                                Console.Write("Enter the Amount to withdraw : ");
                                double amount = double.Parse(Console.ReadLine());
                                obj.Withdraw(amount);
                            }
                            break;
                        case 3:
                            obj.Display();
                            break;
                        default:
                            Console.WriteLine("Invalid Option ...!");
                            break;
                    }
                    Console.Write("Do you wish to perform another Transaction (y/n) : ");
                    decision = Console.ReadKey().KeyChar;
                } while (decision == 'y');
            }
            else
                Console.WriteLine("Invalid Account Selection ...!");
        }
    }
}
