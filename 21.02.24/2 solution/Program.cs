using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vuvejdane na danni
            Console.WriteLine("Kolko 4isla");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolko puti shte zavurtash");
            int a=int.Parse(Console.ReadLine());
            int[] k = new int[n];
            int[] sum = new int[n];
            int i;
            //vhod
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi chislo");
                k[i] =int.Parse(Console.ReadLine());
              
            }
            
            for(int r = 1; r < n; r++)
            {
                sum[i] = 0;
                for (i = 0; i < n; i++)
                    sum[i] = (i + r) % n;
                    sum[i] = sum[i] +r;
            }
            
        }
    }
}
