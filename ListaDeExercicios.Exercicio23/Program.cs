﻿namespace ListaDeExercicios.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Numeros primos ");
            for (int i = 100; i < 201; i++)
            {

                if ((i % 2) != 0)
                {
                    Console.WriteLine("Os números ímpares de entre 100 e 200 são: " + i);


                }
            }
        }     
    }   
}