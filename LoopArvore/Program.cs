using System;

namespace LoopArvore
{
    class Program
    {
        static void Main(string[] args)
        {

            string estrela = "";

            Console.WriteLine("Quantos triângulos?");
            int cont1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o tamanho/ linhas?");
            int cont2 = int.Parse(Console.ReadLine());

            for (int i= 0 ; i < cont1; i++)
            {
                estrela = "";              
                for (int j= 0 ; j < cont2; j++)
                {
                    estrela += "*";   
                    Console.WriteLine(estrela); 
                }
                
            }
        }
    }
}
