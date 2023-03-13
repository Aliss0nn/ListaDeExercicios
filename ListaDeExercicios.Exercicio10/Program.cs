
//media ponderada 02 provas
//        nota de cada prova?             
// o peso de cada prova?



namespace ListaDeExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular a media Ponderada \n");
         
            Console.Write("Digite a nota da prova 1: ");           
            double n1 = double.Parse(Console.ReadLine());
                                  

            Console.Write("Digite a nota da prova 2: ");
            double n2 = double.Parse(Console.ReadLine());
            
            Console.Write("Peso da prova 1: ");
            int p1 = int.Parse(Console.ReadLine());
            

            Console.Write("Peso da prova 2: ");
            int p2 = int.Parse(Console.ReadLine());

            double resultado = 0;

            resultado = ((n1 * p1 + n2 * p2) / (p1 + p2));
  
            Console.Write("Sua Media é: " + resultado);
            Console.ReadLine(); 

            





        }
    }
}