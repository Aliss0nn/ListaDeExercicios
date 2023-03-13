// Converter C para F
// F?   C= x    F = C * 1.8 + 32




namespace ListaDeExercicios.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("   Temperatura em Celsius: ");    
           
            string temperatura = Console.ReadLine();
            double c = Convert.ToDouble(temperatura);

            Console.WriteLine();

            double resultado = 0;

            resultado = c * 1.8 + 32;

            Console.Write(   "Esta temperatura em fahrenheit é: " +  resultado);
            Console.WriteLine();
            Console.ReadLine();




        }
    }
}