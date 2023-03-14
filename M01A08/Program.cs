using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando variáveis

            sbyte n = 20;// somente valores
            Console.WriteLine("A variavel n tem " + n);
            Console.WriteLine("N é do tipo " + n.GetType());


            var nome = "Jean"; // var pode por string
            Console.WriteLine("A variavel nome tem " + nome);
            Console.WriteLine("Nome é do tipo " + nome.GetType());

            Console.ReadKey();
        }
    }
}
