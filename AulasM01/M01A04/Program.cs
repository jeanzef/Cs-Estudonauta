using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 5);/*para posicionar texto*/
            Console.WriteLine("Olá, Mundo!");
            Console.ReadKey();
            Console.Clear();/*para limpar \ tela e subistituir*/
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("Tudo bem?");
            Console.ReadKey();
        }
    }
}
