using System;

namespace MediaDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiorDeIdade = 0;
            int menorDeIdade = 0;
               
            for (int i = 0; i <10 ; i++)            
            {
            Console.WriteLine("Coloque aqui o valor da idade:");
            int resposta = int.Parse(Console.ReadLine());
            
                if (resposta >= 18)
                    maiorDeIdade++;
                
                else
                {
                    menorDeIdade++;
                }
             }
             Console.WriteLine("A quantidade de maiores de 18 é {0}"+maiorDeIdade);
             Console.WriteLine("A quantidade de menores de 18 é {0}"+menorDeIdade);
        }
    }
}