namespace ListaDeExercicio.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite um número: ");

            int numero = int.Parse(Console.ReadLine());

            if ( numero %2 == 0)
            {
                Console.WriteLine(" É par ");           
            }
            
            else
            {
                Console.WriteLine(" Não é par");
            }





        }
    }
}