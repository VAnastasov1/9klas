using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne na pamet
            double[] pari = new double[2];
            string[] vidzakuska = new string[2];
            //vhod
            for(int i = 0;i<2;i++)
            {
                Console.WriteLine("Vuvedi pari:");
                pari[i]=double.Parse(Console.ReadLine());
                Console.WriteLine("Vuvedi zakuska:");
                vidzakuska[i]=Console.ReadLine();
            }
            //izhod
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(vidzakuska[i] + "/" + pari[i]);
            }
        }
    }
}
