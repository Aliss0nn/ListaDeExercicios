using System.ComponentModel.Design;
using System.Transactions;

namespace ListaDeExercicios.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   IMC   ");

            Console.Write(" Digite o seu peso: ");
            double peso = double.Parse(Console.ReadLine());
                
            Console.Write(" Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc;

            imc = (peso / (altura * altura));

            if (imc <= 18.5)
            {
                Console.WriteLine(" Abaixo do peso ");
            }          

            else if ((18.5 < imc) && (imc < 25))
            {
                Console.WriteLine(" Peso normal ");
            }
             
            else if ((25 <= imc) && (30 > imc))
            {
                Console.WriteLine(" Acima do Peso");
            }

            else if ( 30 <= imc)
            {
                Console.WriteLine(" Obeso ");
            }

            Console.ReadLine();
            

        }
    }
}