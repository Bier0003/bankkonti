using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BankAccount
    {
        //crate money and name 
        private double Money = 0;
        private readonly string first_name;

        
        public BankAccount(double money, string first_name)
        {
            
            Money = money;
            this.first_name = first_name;
        }
        public void AddMoney(double amount) 
        {
            Console.WriteLine("Add" + amount + "to the bank account.");
            // money = money + amount;
            Money += amount;
        }
        public void Subtract(double Money)
        {
            Console.WriteLine("Withdraw" + Money + "from bank Account");
            //subtract money from account
            this.Money -= Money;

        }

        public void GetInfo()
        {
            Console.WriteLine(first_name+ "remain: " + Money + "DKK");
        }
    }
}
