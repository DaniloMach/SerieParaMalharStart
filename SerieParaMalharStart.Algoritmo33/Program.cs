using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga um Numero");
            int Q = int.Parse(Console.ReadLine());
            int W = Q;
            int R = Q;
            W++;
            R--;
            Console.WriteLine($"O Numero e {Q} seu sucessor e {W} e o antecessor e {R}");
            Console.ReadKey();
        }
    }
}
