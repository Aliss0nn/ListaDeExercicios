//Volume de uma esfera
//    V = 4/3 * pi * r elavada na 3

// 4/3 * math.pi * Math.Pow( number1 * number2);     number1 = r numeber2 = 3



namespace ListaDeExercicios.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular o Volume De Uma Esfera \n");         
            
            Console.Write(" Digite o valor do seu raio: ");
            
            double raio = Convert.ToDouble(Console.ReadLine());

            double t = 3;
            double result = 0;


                result = (4.0/3.0) * 3.14 * Math.Pow(raio, t);
            
            Console.WriteLine("O Resultado é: " +  result);











        }
    }
}
