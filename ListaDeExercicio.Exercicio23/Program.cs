namespace ListaDeExercicio.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Tabuada  \n ");

            Console.Write(" Informe um numero: ");
            int numero = int.Parse(Console.ReadLine());

            for (  int i = 0; i <= 10; i++ )
            {
                Console.WriteLine(string.Format(" {0}*{1}={2}",numero,i, numero*i));
                
            }

            Console.ReadKey();


        }
    }
}