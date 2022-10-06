using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Numero");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("digite outro numero");
            int Z = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero");
            int O = int.Parse(Console.ReadLine());
            int W = (X + Z +O)/3 ;
            Console.WriteLine($"o Media e {W}");
            Console.ReadKey();
        }
    }
}
