using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace ListaDeExercicio.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Digite o primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write(" Digite o segundo valor: ");
            int v2 = int.Parse(Console.ReadLine());

            Console.Write(" Digite o terceiro valor: ");
            int v3 = int.Parse(Console.ReadLine());


            if (v1 > v2 && v1 > v3)
            {
                if (v2 > v3)
                {
                    Console.WriteLine(v1);
                    Console.WriteLine(v2);
                    Console.WriteLine(v3);
                }
                else
                {
                    Console.WriteLine(v1);
                    Console.WriteLine(v3);
                    Console.WriteLine(v2);
                }
            }
            else if (v2 > v1 && v2 > v3)
            {
                if (v1 > v3)
                {
                    Console.WriteLine(v2);
                    Console.WriteLine(v1);
                    Console.WriteLine(v3);
                }

                else
                {
                    Console.WriteLine(v2);
                    Console.WriteLine(v3);
                    Console.WriteLine(v1);
                }
            }


            else
            {
                if (v2 > v1)
                {
                    Console.WriteLine(v3);
                    Console.WriteLine(v2);
                    Console.WriteLine(v1);
                }

                else
                {
                    Console.WriteLine(v3);
                    Console.WriteLine(v1);
                    Console.WriteLine(v2);
                }

















            }



        }
    }
}