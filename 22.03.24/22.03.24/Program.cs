using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _22._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vuvejdane na danni
            Console.WriteLine("Kolko 4oveka shte zavurshat");
            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            int[] nomer = new int[n];
            string[] predmet = new string[n];
            double[] ocenka = new double[n];
            //vhod 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi ime");
                ime[i] = Console.ReadLine();
                Console.WriteLine("Vuvedi nomer v klas");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedi predmet");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("Vuvedi ocenka");
                ocenka[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Az " + ime[i] + " s nomer v klas " + nomer[i] + " po predmet " + predmet[i] + " imam" + ocenka[i]);
            }
            Console.WriteLine("Izjod 2");
            for (int i = 0; i < n; i++)
            {
                if (ocenka[i] >= 5.25)
                {
                    Console.WriteLine("Az " + ime[i] + " s nomer v klas " + nomer[i] + " po predmet " + predmet[i] + " imamv" + ocenka[i]);
                }
            }
            Console.WriteLine("Izhod 3");
            for (int i = 0; i < ocenka.Length - 1; i++)
            {
                for (int k = 0; k < ocenka.Length - 1; k++)
                {
                    if (ocenka[k] > ocenka[i + 1])
                    {
                        double swapVar = ocenka[k];
                        ocenka[k] = ocenka[k + 1];
                        ocenka[k + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < ocenka.Length; i++)
            {
                Console.WriteLine(ocenka[i] + " ");
            }
            Console.WriteLine("Izhod 4");
            for (int i = 0; i < n; i++)
            {
                if (ime[i] == "Genadi" && nomer[i] >= 5 && nomer[i] <= 10)
                {
                    Console.WriteLine("Ime:" + ime[i] + " Nomera mu e:" + nomer[i]);
                }
            }
            Console.WriteLine("Izhod 5");
                
        }
    }
}
