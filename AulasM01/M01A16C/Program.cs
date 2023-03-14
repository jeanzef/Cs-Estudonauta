using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A16C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            Console.WriteLine("Qual é o seu salário?");
            float.TryParse(Console.ReadLine(), out sal);
            Console.WriteLine($"Você ganha {sal} por mês!");
            // se acaso eu tivesse colocado {sal:c} ele puxaria o sistema monetario da moeda
            // de acordo com o país de onde foi executado
            Console.ReadKey();
        }
    }
}
