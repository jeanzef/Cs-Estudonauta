using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite um número Real:");
            // pode criar variavel sem valor 
            float num;
            float.TryParse(Console.ReadLine(), out num);

            int n1 = (int) num;
            int n2 = Convert.ToInt16(num);

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Você digitou o valor de {num:N}");
            Console.WriteLine($"A parte inteira do número é {n1:D}");
            Console.WriteLine($"Arredondando, temos o número {n2:D}");

            Console.ReadKey();
        }
    }
}
