using System.ComponentModel.Design;

namespace ListaDeExercicio.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" NUMEROS  \n");

            Console.Write(" Primeiro número Inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write(" Segundo número Inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            int n3 = 0;

            if (n1 == n2)
            {
                Console.WriteLine( n3 = n1 + n2 );
            }
            else
            {
                Console.WriteLine( n3 = n1 * n2 );
            }










        }
    }
}