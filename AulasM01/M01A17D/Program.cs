using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A17D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Jean";
            float sal = 550.7556F;
            Console.WriteLine($"O senhor {nome} ganha {sal,10:C3} por mês!");
            Console.ReadKey();
        }
    }
}
