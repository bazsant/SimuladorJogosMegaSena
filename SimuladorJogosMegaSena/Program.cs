using System;
using System.Collections.Generic;

namespace SimuladorJogosMegaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulador de jogos da Mega Sena");
            Console.WriteLine("Digite quantos números quer sortear (de 6 a 15)");
            var entrada = Console.ReadLine();

            if(int.TryParse(entrada, out int quantidadeNumeros))
            {
                if (quantidadeNumeros >=6 && quantidadeNumeros <= 15)
                {
                    Console.Write("\nOs números simulados foram:");
                    SortearNumeros(quantidadeNumeros);
                }
                else
                {
                    Console.WriteLine("A quantidade precisa ser de 6 a 15");
                }
            }
            else
            {
                Console.WriteLine("Não foi possível obter a quantidade");
            }

        }

        private static void SortearNumeros(int quantidadeNumeros)
        {
            Random sorteador = new Random();
            List<int> numeros = new List<int>();
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                var numeroSorteado = sorteador.Next(1, 61);
                while (numeros.Contains(numeroSorteado))
                {
                    numeroSorteado = sorteador.Next(1, 61);
                }

                numeros.Add(numeroSorteado);

                Console.Write($" {numeroSorteado}");
            }
        }
    }
}
