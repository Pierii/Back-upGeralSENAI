using System;

namespace NomeDoMes
{
    class Program
    {
        static void Main(string[] args)
        {

            // int num = 1;

            // while (num != 0)
            // {
            //     Console.WriteLine("Bota o número do mês aqui mano! Se quiser aperte 0");
            //     num = int.Parse(Console.ReadLine());

            // switch (num)
            // {

            //     case 1:
            //         Console.WriteLine("Janeirão");
            //         break;
            //     case 2:
            //         Console.WriteLine("Fevereirão");
            //         break;
            //     case 3:
            //         Console.WriteLine("Marção");
            //         break;
            //     default:
            //         Console.WriteLine("Escolha um número entre 1 e 3!");
            //         break;
            // }
            // }

            bool usuarioAindaQuerJogar = true;
            int cont = 3;
            
            while (cont >= 1 && usuarioAindaQuerJogar)
            {
                Console.WriteLine("Vai encarar mais uma? Cuidado, você só tem mais {0} chance(s)!",cont);                   
                string resposta = Console.ReadLine();
                usuarioAindaQuerJogar = resposta.Equals("sim") ? true : false;  
                cont--;
            }
        }
    }
}
