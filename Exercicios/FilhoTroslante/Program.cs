using System;

namespace FilhoTroslante
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jaAcordei = false;

            do{
                System.Console.WriteLine("Pai, vc já acordou?");
                string resposta = Console.ReadLine();
                
                jaAcordei = resposta.Contains("que") ? true : false;
            } while (!jaAcordei);
        }
    }
}
