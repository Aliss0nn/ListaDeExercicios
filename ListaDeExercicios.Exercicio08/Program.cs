namespace ListaDeExercicios.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("        Calcular o Volume de Uma Lata de óleo \n   ");


            Console.Write("Digite o valor Do Raio da Lata de óleo:  ");
            string Raio = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite a altura da Lata de óleo: ");
            String Altura = Console.ReadLine();
            Console.WriteLine();

            double R = Convert.ToDouble(Raio);
            Double A = Convert.ToDouble(Altura);

            double resultado = 0;

            resultado = 3.14 * R * R * A;

            Console.WriteLine("O Volume é: " + resultado);
        }
    }
}