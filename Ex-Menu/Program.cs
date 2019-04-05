using System;

namespace Ex.Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool repetir =  true;
            
            Console.WriteLine("");
            Console.WriteLine("|===========================|");
            Console.WriteLine("|-------MENU ESTILOSO-------|");
            Console.WriteLine("|===========================|");
            Console.WriteLine("");
            Console.WriteLine("____________________________|");
            Console.WriteLine("");

            while (repetir)
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1. Logar estilo o manito");
                Console.WriteLine("2. Descer de bike com o Pepino");
                Console.WriteLine("3. Fazer o rush meteoro");
                Console.WriteLine("9. Ir de base");
                Console.WriteLine("__________________________|");
                int resposta = int.Parse(Console.ReadLine());
                
                switch (resposta)
                {
                    case 1:
                    Console.WriteLine("Coloque o usuário");
                    Console.WriteLine("__________________________");
                        break;
                    case 2: 
                    Console.WriteLine("Você fica com medo de descer depois que vê o Pepino caindo");
                    Console.WriteLine("__________________________");
                        break;
                    case 3:
                    Console.WriteLine("Vai só rusha!");
                    Console.WriteLine("__________________________");
                        break;
                    case 9:
                    Console.WriteLine("Vlw falou!");
                    Console.WriteLine("__________________________");
                    repetir = false;
                        break;
                    default:
                    Console.WriteLine("Nn entendi mano");
                    break;
                }               
            }
        }
    }
}
