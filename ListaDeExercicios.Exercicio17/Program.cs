namespace ListaDeExercicios.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ver se os primeiros valores são menores que o ultimo \n");           
            
            Console.Write(" Primeiro Valor: ");

            double A = Double.Parse(Console.ReadLine());

            Console.Write(" Segundo Valor: ");

            double B = Double.Parse(Console.ReadLine());

            Console.Write(" Terceiro Valor ");

            double C = Double.Parse(Console.ReadLine());

            double soma = A + B;

            if (soma < C)
            {              
                Console.WriteLine(" é menor mesmo xD");
                Console.ReadLine();
            }

            else 
            {              
                Console.WriteLine(" não é menor ");
                Console.ReadLine();
            }
            
              
            
            


        }
    }
}