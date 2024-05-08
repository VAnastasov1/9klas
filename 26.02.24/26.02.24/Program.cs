using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet
            Console.WriteLine("Kolko pitieta shte piesh?");
            int n = int.Parse(Console.ReadLine());
            string[] pitie = new string[n];
            double[] cena = new double[n];
            int[] broi = new int[n];
            //vhod
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Vuvedi pitie:");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("Vuvedi cena:");
                cena[i]=double.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedi broi ptieta:");
                broi[i] =int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Izhod 1");
            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine("pitie:" + pitie[i] + "/" + "cena:" + cena[i] + "/" + "br.pitieta" + broi[i]);
            }

            Console.WriteLine("Izhod 2:");
            for (int i = 0; i < n; i++)
            {
                if (broi[i] < 2.50)
                { Console.WriteLine("pitie:" + pitie[i] + "/" + "cena:" + cena[i] + "/" + "br.pitieta" + broi[i]); }
            }

            Console.WriteLine("Izhod 3:");
            for (int i = 0; i < n; i++)
            {
                if (cena[i] == 2 && pitie[i] == "kafe")
                { Console.WriteLine("pitie:" + pitie[i] + "/" + "cena:" + cena[i] + "/" + "br.pitieta" + broi[i]); }
                else
                { Console.WriteLine("error"); }
            }

            Console.WriteLine("Izhod 4:");
         
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("pitie:" + pitie[i] + "/" + "cena:" + cena[i] + "/" + "br.pitieta" + broi[i]);
            }

            Console.WriteLine("Izhod 5:");
            for (int i = 0; i < n; i++)
            {
               
            }

            Console.WriteLine("Izhod 6:"); 
            int firstValue = 0;
            int midValue = pitie.Length / 2;
            int lastValue = pitie.Length - 1;
            Console.WriteLine(pitie[firstValue]+"/" +   pitie[midValue]+"/"  +  pitie[lastValue]  ); 

            Console.WriteLine("Izhod 7:");
            for (int i = 0; i < n; i++)
            {
                if (pitie[i] == "kafe")
                { Console.WriteLine("pitie:" + pitie[i] + "/" + "cena:" + cena[i] + "/" + "br.pitieta:" + broi[i]); }
            }
        }
    }
}
