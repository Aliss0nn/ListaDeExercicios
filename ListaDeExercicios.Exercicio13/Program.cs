namespace ListaDeExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Padaria HOTPAO \n  ");

            Console.Write(" Número de vendas do pão francês: ");
            
            double pf = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write(" Número de vendas de Broa: ");

            double br = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double resultado1 = 0;

            resultado1 = (pf * 0.12) + (br * 1.50);

            double resultado2 = 0;
           
            Math.Round(resultado2, 2);
            resultado2 = resultado1 / 10;

            Console.Write("O VALOR TOTAL DE VENDAS É:  "  +  resultado1);
            Console.WriteLine();
            
            Console.Write(" O VALOR QUE DEVERA SER COLOCADO NA POUPANÇA É:  "  +  resultado2);
            Console.ReadLine();




        }
    }
}