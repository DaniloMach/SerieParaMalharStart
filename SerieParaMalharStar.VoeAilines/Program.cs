using SerieParaMalharStar.VoeAilines.Entities;
using SerieParaMalharStar.VoeAilines.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStar.VoeAilines
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Aeronave aero = new Aeronave();
            /*
             * Aeronave : Classe 
             * aero : É o objeto da classe 
             * = : É o que atribui
             * new : Operador de instanciação
             * instância : É o objeto (A concretização de uma classe)
             * Aeronave(): Chamada ao construtor
             * 
            */
            // INTERFACE COM USUARIO
            Console.Write("digite o Artista");
            var entradaCelebridade = Console.ReadLine();
            Console.Write("Digite o Fabricante");
            var entradaFabricante = Console.ReadLine();
            Console.Write("Digite a Matricula");
            var entradaMatricula= Console.ReadLine();
            Console.Write("Digite o Modelo");
            var entradaModelo= Console.ReadLine();
            Console.Write("Ddigite o Codigo");
            var entradaCodigo= Console.ReadLine();
            Console.Write("Digite a Quantidade de Passageiros");
            var entradaQtdePassageiros= int.Parse( Console.ReadLine());
            // ATRIBUIÇOES 
            aero.celebridade = entradaCelebridade;
            aero.Fabricante = entradaFabricante;
            aero.Matricula = entradaMatricula;
            aero.Modelo = entradaModelo;
            aero.Codigo = entradaCodigo;
            aero.Capacidade = entradaQtdePassageiros;

            // NOTICIA
            Console.WriteLine($"Jatinho Executivo do {aero.celebridade} é um  {aero.Modelo}-" +
                $"{aero.Codigo} Cuja a capacidade é {aero.Capacidade} " +
                $"Fabricado pela {aero.Fabricante} " +
                $" de matrícula {aero.Matricula}.");
            Console.ReadKey();

        }
    }
}
