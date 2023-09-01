using BLL;
using DAL;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace bankkonti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Velkommen til mini Bank");
            Console.WriteLine("1 Taste kunde cpr");
            Console.WriteLine("2 Opret kunde ");
            Console.WriteLine();
            var input = Console.ReadLine();

            if (input == "2") 
            { 
            
            
            
            
            
            
            
            
            }



            if (input = false) 
            {
                Console.WriteLine("Cpr. no. er forkert");
            }
            else 
            {
                Console.WriteLine("(a)Opret ny kunde ");
                Console.WriteLine("(b)Sign up");





            }
            Console.WriteLine("(a) ");
            Console.WriteLine("(b)Sign up");
            string input = Console.ReadLine();
            if (input != "a" && input != "b")
            {
                Console.WriteLine("you command a", input);
                user = new();
                Console.WriteLine("Username:");
                string username = Console.ReadLine();
                Console.WriteLine("Password: ");
                string Password = maskPass();



            }
            //// 
            //Console.WriteLine("username :");
            //ConsoleKeyInfo key = Console.ReadKey();
            //// check name in list name if it exit
            //Console.WriteLine("Hei"+ key);
            //Console.WriteLine("pls Enter your password to login..." );
            //Console.WriteLine("password: ");
            //ConsoleKeyInfo keypass = Console.ReadKey();
            //Console.WriteLine(Customer.);
            ////check password for get access.

            //Console.WriteLine("welcome to Bank ");
            //Console.WriteLine("1) insert new account");
            //Console.WriteLine("2) edit new account");
            //Console.WriteLine("3) edit konti");
            //Console.WriteLine("4) search for account");
            //Console.WriteLine("5) Delete account");
            //Console.WriteLine("6) show information");

            BankAccount Account = new BankAccount(money:100, first_name: "Arlen");
          
            Account.AddMoney(amount: 50);
            Account.GetInfo();
            Account.Subtract(Money: 100);
            Account.GetInfo();







            //// give username to login 
            //Console.WriteLine("username :");
            //ConsoleKeyInfo key = Console.ReadKey();
            //// check name in list name if it exit
            //Console.WriteLine("Hei"+ key);
            //Console.WriteLine("pls Enter your password to login..." );
            //Console.WriteLine("password: ");
            //ConsoleKeyInfo keypass = Console.ReadKey();
            //Console.WriteLine(Customer.);
            ////check password for get access.

            
           



            











        }







    }
}