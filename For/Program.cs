using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas estrelas?");
            
            int tamanhoTriangulo = int.Parse(Console.ReadLine());
            string estrela = "";
            
            for (int i = 0; i <tamanhoTriangulo; i++)
            {
                estrela += "*";   
                Console.WriteLine(estrela);
            } 
        }
    }
}
