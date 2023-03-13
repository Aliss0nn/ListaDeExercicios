using System.ComponentModel;

namespace ListaDeExercicios.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("        Calcular o Volume do Cilindro   \n   ");
              
            
            Console.Write("Digite o valor Do Raio do Cilindro: ");           
            string Raio = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite a altura do Cilindro: ");
            String Altura = Console.ReadLine();
            
            Console.WriteLine();            
            
            double R = Convert.ToDouble(Raio);
            Double A = Convert.ToDouble(Altura);

            double resultado = 0;

            resultado = 3.14 * R * R * A;

            Console.WriteLine("O Volume é: " +  resultado);




            




        }


    }
}