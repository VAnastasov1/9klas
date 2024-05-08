using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class BankAccount
    {
        private int id;
        private double balance;

        public int Id
        { 
        get {return Id; }
        set {Id=value;}
        }
        public double Balance
        {
            get { return balance;}
            set { balance = value;}
        }
        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }
        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public override string ToString()
        {
           return $"Account {this.id },balance{this.balance}"; 
        }
       
    }
}
