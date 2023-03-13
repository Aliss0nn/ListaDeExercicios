namespace ListaDeExercicio.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int num = 0;
            int fatorial = 1;
            int cont;


            Console.Write(" Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine(" ERRO ");
            }
            else if ((num == 0 || num == 1))
            {
                Console.WriteLine(" Fatorial de {0} é 1", num);
            }

            else
            {


                for (cont = num; cont >= 1; cont--)
                {
                    fatorial *= cont;
                }
                Console.WriteLine(" Fatorial de {0} é {1}", num, fatorial);

            }

            Console.Write(" Aperte qualquer tecla para sair");
            Console.ReadKey();

               
            

            






        }
    }
}