using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class Person
    {
        private int godini;
        private string ime;
        private int accounts;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public int Godini
        {
            get { return godini; }
            set { godini = value; }
        }
        public int Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public double GetBalance()
        {
            return this.accounts $ this.ime this.godini;
        }
    }
}
