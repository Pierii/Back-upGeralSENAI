using System;

namespace Primeiro_aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;

            Console.WriteLine("Welcome 2 the good side of the world");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Put your name here:");
            nome = Console.ReadLine();
            Console.WriteLine("Put your last name here");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Welcome - "+nome+" "+sobrenome);
        }
    }
}