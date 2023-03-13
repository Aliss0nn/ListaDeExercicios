
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcular Média Harmonica \n");

        Console.Write("Qual a primeira nota: ");
        
        
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Qual a segunda nota: ");
       
        
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Qual a terceira nota: ");
       
     
        double nota3 = double.Parse(Console.ReadLine());

        double notaHarmonica = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));

        Console.WriteLine(Math.Round(notaHarmonica, 2));


    }
}

