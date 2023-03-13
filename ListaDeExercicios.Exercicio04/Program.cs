//Consumo de combustivel
//KM final e inical do percursor do veiculo
//    o consumo de combustivel


// A pessoa da o km inicial do carro





namespace ListaDeExercicios.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consumo de gasosa  \n");

            Console.Write(" Digite a distancia percorrida com o veiculo: ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write(" Digite o volume gasto de gasolina: ");
            double volume = double.Parse(Console.ReadLine());

            double consumo = 0;
            Math.Round(consumo, 2);

            consumo = distancia/volume;
            
            
            Console.WriteLine(" Seu consumo médio é de: " + consumo + "KM/L");
            Console.ReadLine();

            


        }
    }
}