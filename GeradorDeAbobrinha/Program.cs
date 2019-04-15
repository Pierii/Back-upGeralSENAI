﻿using System;

namespace GeradorDeAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Vou gerar abrobineas kkkkkkkjk");
            Console.WriteLine("Escreve as palavras mano");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 8;
                    
            string[] palavrasUsuario  = new string [maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0 ; i++)
            {
                palavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)
                {
                    System.Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma!");

                }
                else
                {
                System.Console.WriteLine("Agr vaza menó!");
                }
            }
            string [,] matrizPalavras = {
                                            {"batata","Fiz","","","de"},
                                            {"Nosfa","emcima","","Gotas","Delícia"},
                                            {"Talquei","","Mel","Balita",""},
                                            {"Construção","Eu","Escola","Não",""},
                                            {"q ota?","antes","Pente","","Abelha"}
                                        };
            
            for (int i = 0; i <matrizPalavras.GetLength(0); i++)
            {
                for (int j = 0; j <matrizPalavras.GetLength(0) ; j++)
                {
                    if("".Equals(matrizPalavras[i,j]))
                    {
                        matrizPalavras[i,j] = palavrasUsuario[i];
                    }
                }
            }       
            string frase = "";

            Random r = new Random();
            for (int i = 0; i <maxPalavrasFrase; i++)
            {
                frase += matrizPalavras[r.Next(matrizPalavras.GetLength(0)),
                                        r.Next(matrizPalavras.GetLength(0))]
                                        + " ";
            }
            System.Console.WriteLine("Minha frase é \n"+frase);
        }
    }
}
