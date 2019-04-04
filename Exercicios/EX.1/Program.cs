using System;

namespace EX._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOTA O VALOR!");

            double valor1;
            double valor2;

            double calculo;

            Console.WriteLine("Digite o primeiro valor:");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = double.Parse(Console.ReadLine());

            calculo = valor1 - valor2;

            if (calculo > 0)
            {
                Console.WriteLine("O primeiro número é maior!");
            }
            if (calculo < 0)
            {
                Console.WriteLine("O segundo número é maior!");
            }
            if (calculo == 0)
            {
                Console.WriteLine("Os números são iguais!");
            }
        }
    }
}
