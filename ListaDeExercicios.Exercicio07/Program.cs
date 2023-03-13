namespace ListaDeExercicios.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário Base: ");

            double salarioinicial = double.Parse(Console.ReadLine());

            Console.Write(" Digite o total de vendas: ");

            double totaldevendas = double.Parse(Console.ReadLine());

            Console.Write(" Digite o percentual das vendas: ");

            double percentualvendas = double.Parse(Console.ReadLine());

            double resultado = 0;

            resultado = salarioinicial + (totaldevendas * percentualvendas) / 100;

            Console.WriteLine();
            
            Console.WriteLine(" O salário final é " +  resultado);


        }
    }
}