using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A17E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo";
            int valoresEm = 22;

            // Valor monetario dinheiro
            Console.WriteLine($"O gustavo tem valores em {valoresEm,10:C}");



            // Valor Decimal (inteiro)
            Console.WriteLine($"O gustavo tem valores em {valoresEm,10:D}");
            /* Valor Decimal (inteiro) com o D tendo 3 casas decimais elas entram na 
            esquerda 1 (antes) da virgula ao contrario de C que os valores entram na 
            direita 1 (depois) da virgula*/
            Console.WriteLine($"O gustavo tem valores em {valoresEm,10:D3}");



            // Valor Número (real)
            Console.WriteLine($"O gustavo tem valores em {valoresEm,10:N}");

            // Valor Científico
            Console.WriteLine($"O gustavo tem valores em {valoresEm,10:E}");

            // Valor Hexadecimal
            Console.WriteLine($"O gustavo tem valores em {valoresEm,10:X}");


            Console.ReadKey();
        }
    }
}
