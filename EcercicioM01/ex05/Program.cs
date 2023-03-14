using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEm que ano você nasceu? ");
            int nasc = 0;
            int.TryParse(Console.ReadLine(), out nasc);
            int atual = DateTime.Now.Year;
            int idade = atual - nasc;
            //Mostrando o resultado
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"O ano atual é {atual}.");
            Console.WriteLine($"Você nasceu em {nasc}.");
            Console.WriteLine($"Você tem {idade} anos de idade.");
            Console.ReadKey();
        }
    }
}
