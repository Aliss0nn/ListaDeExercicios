﻿namespace ListaDeExercicios.Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tabuada ");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
            }

        }
    }
}