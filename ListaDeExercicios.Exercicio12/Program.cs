namespace ListaDeExercicios.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("   Calcular a Area do terreno \n");
            Console.WriteLine();
            
            Console.Write(" Digite o valor da Base: ");
 
            double b1 = double.Parse(Console.ReadLine());
            
            Console.Write( "Digite o valor da Altura: ");           

            double a1 = double.Parse(Console.ReadLine());

            double result = 0;

            result = b1 * a1;

            Console.WriteLine(" O valor da area é: " +  result);


        }
    }
}