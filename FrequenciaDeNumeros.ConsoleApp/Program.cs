using System;

namespace FrequenciaDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de números a serem lidos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine()); ;

            int[] numeros = new int[quantidade + 1];
            int repeticao = 0;

            for (int i = 1; i <= quantidade; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] == numeros[i])
                {
                    Console.WriteLine($"O número {numeros[i]} aparece {repeticao} vezes.");

                }

            }
        }
    }
}
