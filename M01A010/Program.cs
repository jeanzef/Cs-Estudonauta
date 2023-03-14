using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão do tipo implicita
            int a = 1;
            float b = 2;

            Console.WriteLine(" O valor de a é " + a + " do tipo " + a.GetType());
            Console.WriteLine(" O valor de b é " + b + " do tipo " + b.GetType());
            



            // Conversão do tipo explícita
            float x = 8.534f;
            int y = (int) x;
            Console.WriteLine(" O valor de x é " + x + " do tipo " + x.GetType());
            Console.WriteLine(" O valor de y é " + y + " do tipo " + y.GetType());

            // Conversão por classe auxiliar 

            float c = 8.75f;
            int d = Convert.ToInt16(c);

            Console.WriteLine(" O valor de c é " + c + " do tipo " + c.GetType());
            Console.WriteLine(" O valor de d é " + d + " do tipo " + d.GetType());
            Console.ReadKey();

        }
    }
}
