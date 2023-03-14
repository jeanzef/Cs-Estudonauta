using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte idade = 5;
            ushort publico = 45_239;
            float media = 4.5F;
            decimal estrela = 4.5489612357M;
            bool aprovado = false;
            int x;
            var y = 5.5;/* si for  5; é Int de 32
                       si for  5.5; é Duble
                       si for  5.5M; é Decimal
                       si for  5.5F; é Float
                       si for  5.5L; é Long*/
            Console.WriteLine(y.GetType());
            Console.ReadKey();

        }
    }
}
