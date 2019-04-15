using System;

namespace CanalhaAviacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nome = new string [5];
            int [] numeroPassagem = new int [5];
            DateTime [] data = new DateTime [5];
                
                for (int i = 0; i <5; i++)
                {
                    
                Console.WriteLine("___________________________");
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1. Registrar Passagem");
                Console.WriteLine("2. Visualizar Passagens");
                Console.WriteLine("0. Ir de base");
                Console.WriteLine("___________________________");
                int resposta = int.Parse(Console.ReadLine());
                           
                    if ( resposta == 1)
                    {
                    Console.WriteLine("Insira seu nome e sobrenome:");
                    nome[i] = Console.ReadLine();
                    
                    Console.WriteLine("__________________________");

                    Console.WriteLine("Digite o número da passagem:");
                    numeroPassagem[i] = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("__________________________");
                    
                    Console.WriteLine("Insira a data do vôo em dd/mm/aaaa");
                    data[i] = DateTime.Parse(Console.ReadLine());
                    
                    }

                    if (resposta == 2)
                    {
                        for (int j = 0; j <=5; j++)
                        {
                            Console.WriteLine("Comprador:"+nome[j]+", com a passagem de número "+numeroPassagem[j]+" ,fez o agendamento para dia "+data[j]  );
                    Console.WriteLine("__________________________");
                        }
                    }

                    if (resposta == 0)
                    {
                    Console.WriteLine("AirlinesAirlines agradece a preferência!");
                    Console.WriteLine("__________________________");
                    }
                    
                }
        }
    }
}
