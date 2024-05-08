using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("4isla:");
            int n = int.Parse(Console.ReadLine());
            int[] chisla = new int[5];
          
            //vhod
            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine("Vuvedi chislo:");
                chisla[i] =int.Parse(Console.ReadLine());
            }
            Console.WriteLine("izhod bez posleden element:");
         
            for (int i = 0; i < 4; i++)
            {
                
                chisla[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(chisla[i]);
                chisla[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
