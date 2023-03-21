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
            int ini, fim;
            Console.WriteLine("\nSORTEADOR DE NÚMERO");
            Console.WriteLine("-----------------------");
            Console.Write("Início: ");
            int.TryParse(Console.ReadLine(), out ini);
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out fim);



            Console.WriteLine("-----------------------");
            /* aqui o SetCursorPosition indica a posição que ele (ira estar) ou (aparecer) 
            E lembrando que o SetCursorPosition é colocado no codigo em cima da referencia em que ele 
            ira posicionar */
            Console.SetCursorPosition(0, 6);
            Console.Write("Sorteando...");
            /* Aqui o Thread é o temporizador*/
            Thread.Sleep(2000);



            /* Aqui o Random é o gerador de numeros aleatorios */
            Random gerador = new Random();
            /* aqui o int num vai receber o gerador que ira gerar o proximo número que vai do 
             inicio ao fim */
            int num = gerador.Next(ini, fim + 1);
            /*aqui o SetCursorPosition vai fazer com que apareça na tela o nesta posição 
             assim irá substituir o Sorteando...  sobre pondo ele*/
            Console.SetCursorPosition(0, 6);
            Console.WriteLine($"Entre {ini} e {fim} sorteei o valor {num}");

            Console.ReadKey();
        }
    }
}
