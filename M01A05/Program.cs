using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*colocando cores*/
            Console.SetCursorPosition(50, 10);
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.BackgroundColor= ConsoleColor.White;
            Console.WriteLine("Olá, mundo!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(100, 50);
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.BackgroundColor= ConsoleColor.Red;
            Console.WriteLine("Tudo bem?");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
