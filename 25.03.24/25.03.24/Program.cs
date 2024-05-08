using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _25._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet
            Console.WriteLine("Shte se napiq li taq vecher");
            int n = int.Parse(Console.ReadLine());
            string[] pitie = new string[n];
            int[] kolichestvo = new int[n];
            int[] broi = new int[n];
            //vhod
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi pitie");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("Vuvedi kolichestvo");
                kolichestvo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedi broi");
                broi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ti piesh " + pitie[i] + " samo " + broi[i] + " broiki");
            }
            Console.WriteLine("Izhod 2");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Tvoite " + kolichestvo[i] + " litra sa " + kolichestvo[i] * 1000 + " mililista");
            }
            Console.WriteLine("Izhod 3");
            for (int i = 0; i < n; i++)
            {
                if (broi[i] > 2)
                { Console.WriteLine("Ti piesh " + pitie[i] + " samo " + broi[i] + " broiki"); }
            }

            Console.WriteLine("Izhod 4");
            for (int i = 0; i < broi.Length - 1; i++)
            {
                for (int j = 0; j < broi.Length - 1; j++)
                {
                    if (broi[j] > broi[j + 1])
                    {
                        int swapVar = broi[j];
                        broi[j] = broi[j + 1];
                        broi[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < broi.Length; i++)
            { Console.WriteLine(broi[i] + " "); }

            Console.WriteLine("Izhod 5");
            string a = Console.ReadLine();
            Console.WriteLine("Shte vuvejdash li oshte");
            
        }
    }
}
