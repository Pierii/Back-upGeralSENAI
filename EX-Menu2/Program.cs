using System;

namespace Ex.Menu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu dhr!");

            bool replay = true;

            while (replay)
            {
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Capotar");
            Console.WriteLine("3 - Segredo muito secreto");
            Console.WriteLine("0 - Sair vazado!");

            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
                {
                    case 1:
                    Console.WriteLine("Coloque o usuário");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("__________________________");
                    

                    Console.WriteLine("Coloque a senha");
                    string senha = Console.ReadLine();
                    
                    if (usuario == "Choris"  && senha == "1234")
                    {
                        Console.WriteLine("O "+usuario+" tá de volta no pedaço");
                        Console.WriteLine("_______________________");
                    }
                    else{
                        Console.WriteLine("Quem é você mano?");
                    }
                        break;
                    case 2: 
                    Console.WriteLine("Capotou o corsa");
                        break;
                    case 3:
                    Console.WriteLine("Laranjas são laranjas");
                        break;
                    case 0:
                    Console.WriteLine("Falouu!");
                    replay = false;
                        break;
                    default:
                    Console.WriteLine("Insira um valor novamente");
                    break;
                }               
            }
        }
    }
}
