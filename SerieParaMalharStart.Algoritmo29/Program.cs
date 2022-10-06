using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soma = 0;
            var subtracao = 0;
            var multiplicacao = 0;
            var divisao = 0.0m;
            
            /*Console.WriteLine("Digite o nome do professor ");
            var nome = Console.ReadLine(); 
            Console.WriteLine($"O nome e {nome}");
            */
            // var materias = new[] { "C#","Banco de dados" };
            int[] numeros = new int[10];
            numeros[0] = 15;
            numeros[1] = 37;
            numeros[2] = 19;
            numeros[3] = 73;
            numeros[4] = 81;
            numeros[5] = 24;
            numeros[6] = 66;
            numeros[7] = 92;
            numeros[8] = 17;
            numeros[9] = 22;

            /*
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);
            Console.WriteLine(numeros[4]);
            Console.WriteLine(numeros[5]);
            Console.WriteLine(numeros[6]);
            Console.WriteLine(numeros[7]);
            Console.WriteLine(numeros[8]);
            Console.WriteLine(numeros[9]);
           */

            //Loop Looping
            /*
             * Repetição ciclica de Algo.
             * O Looping tambem tem o conceito de algo infinito.
             * Infinito geralmente e um erro.
             * O Looping e executado quando tem uma função 
             * O Looping quando esta em ação ter gatilho de parada 
             * ResulTADO: O LOOPING TEM UMA FUNÇÃO REPETITIVA ATE QUE TENHA UMA PARADA 
             * 
             * 
             * 
             * Consideração do professor:
             * =========================================================================================
             * Vamos trabalhar com esses 2
             * -Loopin finito com controle de sentinela 
             * -Looping Finito sem controle de sentinela
             * =========================================================================================
             * Podemos enfrentar esse 2 
             * -Looping infinito como um erro 
             * -Looping infinito com algum proposito cientifico ou usado em Main Frames 
             * 
             * 
             * 
             */
            int op;
            do
            {
                Console.WriteLine("1-listar 2-processar 3-soma 4-subtração 5-multiplicação 6-divisão" +
                    " 7-sair");
                op =int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: Console.WriteLine("mostrando valores: ");
                        //i= i + 1
                        for (var i = 0; i < numeros.Length; i++)
                        {
                            Console.WriteLine(numeros[i]);
                        }
                        break;
                        case 2:
                        Console.WriteLine("processando valores");
                        foreach (var item in numeros)
                        {

                             soma = soma + item;
                             subtracao = subtracao - item;
                            multiplicacao = multiplicacao * item;
                            divisao = Convert.ToDecimal( divisao)  / (item);

                        }break;
                    case 3:
                        
                            Console.WriteLine($"Asoma e {soma}");


                        { }break;
                    case 4:
                        
                            Console.WriteLine($" A Subtração e {subtracao}");


                        { }break;
                    case 5:
                        
                            Console.WriteLine($"a multiplicação e {multiplicacao}");
                        { }break;
                    case 6:
                        
                            Console.WriteLine($"a divisão e {divisao}");
                        { }break;
                    case 7:
                        {
                            Console.WriteLine("saida");
                            Console.ReadKey();
                        }
                        break;
                }

               
                


            } while (op!= 7);
                


        }
    }
}
