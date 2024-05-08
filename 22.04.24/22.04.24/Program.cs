using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount acc = new BankAccount();
            //acc.Id = 1;
            //acc.Deposit(20);
            //acc.Withdraw(30);
            //Console.WriteLine(acc.ToString());

            var accounts = new Dictionary<int, BankAccount>();
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split();

                var id = int.Parse(cmdArgs[1]);
                if (accounts.ContainsKey(id))
                    Console.WriteLine("Accounta veche go ima");
                else
                {
                    var acc = new BankAccount();
                    acc.Id = id;
                    accounts.Add(id, acc);
                }
                var cmdType = cmdArgs[0];
                switch(cmdType)
                {
                    case "Create":Create(cmdArgs,accounts); break;
                    case "Deposit":Deposit(cmdArgs,accounts); break;
                    case "Withdraw":Withdraw(cmdArgs,accounts); break;
                    case "Print":Print(cmdArgs,accounts); break;
                }
            }

        }
    }
}
