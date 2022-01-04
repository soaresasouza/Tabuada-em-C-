using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteTabuada 
{
    public class Program
    {
        public static void Main(string[] args)
        {
                  
            System.Console.WriteLine("Qual valor você quer calcular?");
            int tabuada = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Quantas vezes quer multiplicar?");
            int nVezes = Int32.Parse(Console.ReadLine());

            Console.WriteLine("====================");
            Console.WriteLine($"TABUADA DE {tabuada}");
            Console.WriteLine("====================");

            for (int i = 1; i <= nVezes; i++)
            {
                Console.WriteLine($"{tabuada} x {i} = {tabuada*i}");
            }
            System.Console.WriteLine("Pressine qualquer tecla para sair"); //opção pra facilitar o uso do executável
            Console.ReadKey();
        }
    }
}