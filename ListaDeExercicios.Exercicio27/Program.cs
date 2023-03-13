namespace ListaDeExercicios.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite um número: ");
            int n = int.Parse(Console.ReadLine());
                       
            int x = 1;
            int y = 0;
            int z = 0;
            

            for ( int i = 0; i <= n; i++ ) 
            {
                z = x + y;
                Console.WriteLine(z);
                y = x;
                x = z;
            }

            Console.ReadLine();


        }
    }
}