using System;

namespace BangDoTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como está o clima?");
            string clima = Console.ReadLine().ToLower();

            if (clima.Equals("frio"))
            {
                Console.WriteLine("Vamos à montanha!");
            }
            else if (clima.Equals("calor"))
            {
                Console.WriteLine("Vamos à praia!");
            }
            else if (clima.Equals("chuva"))
            {
                Console.WriteLine("vamos para a Steam?");
                string resposta = Console.ReadLine();
                if (resposta.Equals("Não"))
                Console.WriteLine("Vamos para a Netflix!");
            }
            else{
                Console.WriteLine("Valor inválido \n Digite frio, calor ou chuva.");
            }
        }
    }
}   