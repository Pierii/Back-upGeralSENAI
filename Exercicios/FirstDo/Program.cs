using System;

namespace FirstDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Visualiazdor de Poder de Luta");

            int cont = 0;

            Console.WriteLine("Analizar o poder?");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
            do{
                Console.WriteLine("O Poder de luta do Kakaroto até agora é de mais de "+cont+"!");
                cont += 1000;
            }while (cont < 8000);
            {
                Console.WriteLine("O PODER DE LUTA DO KAKAROTO É DE MAIS DE "+cont+"!!!!!!");
            }
            }
            else
            {
                System.Console.WriteLine("UÉ");
            }
        }
    }
}
