namespace ListaDeExercicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("    Numero é primo ou não    ");
            Console.ReadLine();

            Console.Write("Digite um numero: ");
           
            Console.WriteLine();


            int num = int.Parse(Console.ReadLine());
            int cont = 1;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    cont = cont + 1;
                }
            }

            if (cont == 2)
                Console.WriteLine("O numero {0} e primo", num);
            else
                Console.WriteLine("O numero {0} NAO E primo", num);
        }
    }





}
    
