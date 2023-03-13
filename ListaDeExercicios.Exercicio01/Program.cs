using System.Reflection.Metadata;

namespace ListaDeExercicios.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("   Calcular Volume De Uma caixa retangular \n");           
           
            Console.Write("Digite o comprimento: ");
            
            int comprimento = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine();
           
            Console.Write("Digite a largura: ");
           
            int largura = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine();
           
            Console.Write("Digite a altura: ");

            int altura = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;

            Console.WriteLine();
            resultado = comprimento * largura * altura;

            Console.Write("O Volume é: " + resultado);
        }
    }
}