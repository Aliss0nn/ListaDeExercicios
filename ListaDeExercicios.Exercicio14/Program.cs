namespace ListaDeExercicios.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(" Qual é o seu nome? ");
            
            string nome = Console.ReadLine();

            Console.Write(" Qual a sua idade? ");           
           
            int idade = int.Parse(Console.ReadLine());

            int resultado = 0;

            resultado = 365 * idade;

            Console.WriteLine( nome +  "VOCE JA VIVEU" + (resultado) + "DIAS");
             



        }
    }
}