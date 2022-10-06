using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Numero");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("digite outro numero");
            int Z = int.Parse(Console.ReadLine());
            int W = X+ Z;
            Console.WriteLine($"A Soma e {W}");
            Console.ReadKey();
        }
    }
}
