using System;

namespace Exercico_3
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor, resultado;
            Console.WriteLine("Digite um valor inteiro: ");
            valor = Convert.ToInt32(Console.ReadLine());
            resultado = Convert.ToInt32(Math.Sqrt(valor));

            Console.WriteLine("Resultado: " + resultado);

            Console.ReadKey();
               
        }
    }
}
