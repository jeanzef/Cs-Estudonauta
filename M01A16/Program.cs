using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! tudo bem?");


            Console.ReadKey();
        }
    }
}
