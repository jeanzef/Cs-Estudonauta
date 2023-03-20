using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SORTEADOR DE NÚMERO");
            Console.WriteLine("---------------------");

            Console.Write($"Início: ");
            int inicio = 0;
            int.TryParse(Console.ReadLine(), out inicio);
            Console.Write("Fim: ");
            int fim = 0;
            int.TryParse(Console.ReadLine(),out fim);
            Console.WriteLine("---------------------");
            Console.WriteLine("Sorteando...");
            Thread.Sleep(3000);
            Console.Write("feito");


            Console.ReadKey();
        }
    }
}
