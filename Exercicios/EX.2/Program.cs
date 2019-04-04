using System;

namespace EX._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tal saber se você pode votar?");

            float ano;

            Console.WriteLine("Em que ano você nasceu?");
            ano = float.Parse(Console.ReadLine());

            if (ano <= 2003)
            {
                Console.WriteLine("Você pode votar!");
            }
            else if(ano > 2003)
            {
                Console.WriteLine("Que sorte! Você ainda não pode votar!");
            }
        }
    }
}