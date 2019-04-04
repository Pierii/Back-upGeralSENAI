using System;
namespace CODING_DOJO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quer jogar Par ou impar? MENÓ");
            string resposta = Console.ReadLine().ToLower();
            Random r = new Random();
            int numeroPC = r.Next(0, 10);
            double operacao;
            switch (resposta)
            {
                case "não":
                    Console.WriteLine("Da hora flws");
                    break;

                case "sim":
                    Console.WriteLine("PAR ou ÍMPAR cz?");
                    string time = Console.ReadLine().ToLower();
                    break;

                default:
                    Console.WriteLine("Defina sim ou não , vacilão , vou de base");
                    break;
            }
            if (resposta.Equals("sim")) 
            { 
                Console.WriteLine("Qual o numéro carai"); 
            }
                
                double vc = double.Parse(Console.ReadLine());
                
                operacao = (numeroPC + vc);
            
                if (operacao % 2 == 0) 
                { 
                    Console.WriteLine("YOU WIN"); 
                } 
                else if (operacao % 2 == 1) 
                { 
                    Console.WriteLine("YOU LOSE ARROMBADO"); 
                }
        }
    }
}