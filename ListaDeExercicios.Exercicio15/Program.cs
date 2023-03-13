namespace ListaDeExercicios.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Calcular sálario com impostos e aumento");
            Console.ReadLine();
            
            Console.Write(" Digite o seu salário: ");
            double valorinicial = double.Parse(Console.ReadLine());

           
            double valorcomaumento;

            double valorfinal = 0;

            double resultado1= 0;
            resultado1 = (valorinicial * 1.15);


            valorcomaumento = resultado1 * 0.92;

            valorfinal = valorcomaumento;
            Console.WriteLine();
            
            Console.WriteLine("O salario final é  " + valorfinal);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}