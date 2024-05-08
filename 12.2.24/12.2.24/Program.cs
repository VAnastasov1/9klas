using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Колко души ще въвеждаш?");
            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            double[] money = new double[n];

            Console.WriteLine("Vuvejdane na danni:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ime");
                ime[i] = Console.ReadLine();
                Console.WriteLine("djobni");
                money[i] = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Izhod 1:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ime[i] + " ima " + money[i] + "lv");
            }
            Console.WriteLine("izhod 2:");
            for (int i = 0; i < n; i++)
            {
                if (money[i] >= 7)
                {
                    Console.WriteLine(ime[i] + " ima " + money[i] + "lv");
                }
            }
            Console.WriteLine("Izhod 3:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ime[i] + " ima " + (money[i]-2) + "lv");
            }
        }
    }
}
