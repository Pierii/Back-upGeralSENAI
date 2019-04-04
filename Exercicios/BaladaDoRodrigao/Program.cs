using System;

namespace BaladaDoRodrigao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("E o rolê?");

            string resposta;

            Console.WriteLine("Tá livre no dia?");
            resposta = Console.ReadLine().ToLower();

            else if (resposta.Equals("sim"))
            {
                Console.WriteLine("Vc já é de maior né?");
                resposta = Console.ReadLine().ToLower();
            }
            if (resposta.Equals("não"))
            {
                Console.Write("Sem idade");
            }
            if (resposta.Equals("sim"))
            {
                Console.WriteLine("Tu tem acesso?");
                resposta = Console.ReadLine().ToLower();
            }
            if (resposta.Equals("sim"))
            {
                Console.WriteLine("SEXTOOOU!!!");
            }
            else
            {
                Console.WriteLine("Sem tempo irmão, faço SENAI, fecha o rolê em outro dia que é GG.");
            }
        }
    }
}
