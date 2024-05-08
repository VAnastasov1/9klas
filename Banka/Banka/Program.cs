using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount acc = new BankAccount();

            Person person = new Person();

            Console.WriteLine("Kolko danni shte vuvejdash");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
            Console.Write("Kak se kazvash ");
            Person.ime(Console.ReadLine());
            Console.Write("Na kolko godini si ");
            Person.godini(int.Parse(Console.ReadLine()));
            }

            Console.Write("Kolko shte vkarvash ");
            acc.Deposit(int.Parse(Console.ReadLine()));
            Console.Write("Kolko shte teglish ");
            acc.Withdraw(double.Parse(Console.ReadLine()));
            Console.WriteLine(acc.ToString());


            //if (acc.Withdraw > Balance)
            //{
            //    Console.WriteLine("Ne ti dostigat " + acc.Balance);
            //}
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if(oldestMemberMethod != null || addMemberMethod==null)
            {
                throw new Exception();
            }

        }
    }
}
