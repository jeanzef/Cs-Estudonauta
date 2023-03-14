using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            Thread.Sleep(1000);
            Console.Write("Hoje ");
            Thread.Sleep(1000);
            Console.Write(" é ");
            Thread.Sleep(1000);
            Console.Write(" dia ");
            Thread.Sleep(1000);
            Console.Write( dia );
            Thread.Sleep(1000);
            Console.Write(" do ");
            Thread.Sleep(1000);
            Console.Write(" mês ");
            Thread.Sleep(1000);
            Console.WriteLine( mes );
            Thread.Sleep(3000);

        }
    }
}
