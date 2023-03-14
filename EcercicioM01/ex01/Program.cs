using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.SetCursorPosition(5, 5);
            //Primeira Parte
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write(" MEU ");
            Console.ResetColor();

            // Segunda Parte
            Thread.Sleep(1000);
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write(" BRASIL ");
            Console.ResetColor();

            //Terceira Parte
            Thread.Sleep(1000);
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine(" BRASILEIRO ");
            
           
            Console.ReadKey();
        }
    }
}
