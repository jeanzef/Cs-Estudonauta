using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipos primitivos de valores
            Console.WriteLine("O tipo byte vai de " + byte.MinValue + " até " + byte.MaxValue); // Usa 1 byte (8 byts)
            Console.WriteLine("O tipo sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue); // Usa 1 byte (8 byts)
            Console.WriteLine("O tipo short vai de " + short.MinValue + " até "  + short.MaxValue); // Usa 2 byte (16 byts)
            Console.WriteLine("O tipo ushort vai de " + ushort.MinValue + " até " + ushort.MaxValue); // Usa 2 byte (16 byts)
            Console.WriteLine("O tipo int vai de " + int.MinValue + " até " + int.MaxValue); // Usa 4 byte (32 byts)
            Console.WriteLine("O tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue); // Usa 4 byte (32 byts)
            Console.WriteLine("O tipo long vai de " + long.MinValue + " até " + long.MaxValue); // Usa 8 byte (64 byts)
            Console.WriteLine("O tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue); // Usa 8 byte (64 byts)

            // Valores numéricos reais 
            Console.WriteLine("O tipo uint vai de " + float.MinValue + " até " + float.MaxValue); // Usa 4 byte (32 byts)
            Console.WriteLine("O tipo long vai de " + double.MinValue + " até " + double.MaxValue); // Usa 8 byte (64 byts)
            Console.WriteLine("O tipo ulong vai de " + decimal.MinValue + " até " + decimal.MaxValue); // Usa 16 byte (128 byts)

            // Valores Lógicos
            Console.WriteLine("O tipo ulong vai de " + bool.FalseString + " ou " + bool.TrueString); // Usa 1 bit (True e False)


            Console.ReadKey();

        }
    }
}
