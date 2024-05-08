using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi 5 4oveka");
            
            int[] nomer = new int[5];
            string[] ime = new string[5];

            for(int i = 0; i < 5 ;i++)
            {
                Console.Write("ime:");
                ime[i]=Console.ReadLine();
                Console.Write("nomer:");
                nomer[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("izhod 1");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ime:" + ime[i] + "nomer:" + nomer[i]);
            }
            Console.WriteLine("izhod 2");
            for (int i = 0; i < 5; i++)
            {
                if (nomer[i] > 3)
                { Console.WriteLine("Ime:" + ime[i] + "nomer:" + nomer[i]); }
            }

            Console.WriteLine("izhod 3");
            Console.WriteLine("Kakvo ime iskam da tursq:");
            string name = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (ime[i]==name)
                { Console.WriteLine("Ime:" + ime[i] + " " + "nomer:" + nomer[i]); }
                else
                { Console.WriteLine("error"); }
            }

        }
    }
}
