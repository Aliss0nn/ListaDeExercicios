namespace ListaDeExercicios.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Impares \n");

            int soma = 0;
            for (int i = 1; i <= 500; i++)
            {
               if ( i % 2 != 0 )
               {
                    if ( i % 3 == 0)                                     
                        soma = soma + i;
                    
               }                                         
            }
            Console.WriteLine("O resultado é: " + soma);
            Console.ReadLine();
        }
    }
}