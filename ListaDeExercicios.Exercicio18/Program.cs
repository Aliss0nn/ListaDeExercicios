using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace ListaDeExercicios.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {                                           
            
            Console.WriteLine(" Digite o primeiro valor:  ");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o segundo valor:  ");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o terceiro valor:  ");
            int v3 = int.Parse(Console.ReadLine());
           

            if (v1 == v2)
            {
                Console.WriteLine(" Numeros iguais tente novamente ");

                if (v1 == v3) ;

                Console.WriteLine(" Numeros iguais tente novamente ");

            }

            if ((v1 > v2) && (v1 > v3) && (v2 > v3)) ;
            {
                Console.WriteLine(v1);
                Console.WriteLine(v2);
                Console.WriteLine(v3);
            }

            if ((v2 > v1) && (v2 > v3)) ;
            {
                Console.WriteLine(v2);
            }

            if ((v3 > v2) && (v3 > v1)) ;
            {
                Console.WriteLine(v3);
            } 
                

            

                

            

           





        }
    }
}