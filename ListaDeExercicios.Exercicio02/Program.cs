
//Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
// Farenheint para Celsius
// F - 32/1,8

namespace ListaDeExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite aqui sua temperatura em Fahrenheint: ");           
            string temperatura = Console.ReadLine();
            double temperaturaemFarenheint = Convert.ToDouble(temperatura);
            
            Console.WriteLine();

            double resultado = 0;

            resultado = (temperaturaemFarenheint - 32) / 1.8;

            Console.Write("Esta temperatura em Celsius é:" + resultado);
            Console.WriteLine();
            Console.ReadLine();
           
        }
    }
}