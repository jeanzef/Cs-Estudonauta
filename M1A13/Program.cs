using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1A13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int n = gerador.Next(200);
            // se você colocar um numero (1 , 4) ele vai gerar a partir do 1 e até o 4 
            // mais nesse caso seria 1 2 3 apenas o 0 é 1 e o 4 não conta

            Console.WriteLine("Acabei de gerar o número " + n);
            Console.ReadKey();
        }
    }
}
