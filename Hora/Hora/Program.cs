using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Hora person = new Hora();
            Console.WriteLine("Kolko 4oveka");
            int n=int.Parse(Console.ReadLine());
            //vhod
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Kak se kazvash");
                person.ime=Console.ReadLine();
                Console.WriteLine("Na kolko si");
                person.godini =int.Parse(Console.ReadLine());
                Console.WriteLine("Ot de si");
                person.grad = Console.ReadLine();
                Console.WriteLine($"{person.ime} {person.godini} {person.grad} ");
            }
            
            Console.WriteLine("Izhod 1");
            for (int i = 0; i < n; i++)
            {
                if(person.grad=="sopot")
                {
                    Console.WriteLine($"{person.ime} {person.godini} {person.grad}");
                }
                else
                {
                    Console.WriteLine("Nqma sopotnenec");
                }
            }
            
        }
    }
}
