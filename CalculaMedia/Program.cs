﻿using System;

namespace Ex.Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular!");

            float nota1;
            float nota2;
            float nota3;
            int faltas; 
            float soma;

            Console.WriteLine("Digite a primeira nota");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            nota3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            faltas = int.Parse(Console.ReadLine());
            
            soma = nota1 + nota2 + nota3;
            
            double media = soma/3;

        Console.WriteLine("A soma é "+soma+" é a média é "+media); 
        
        if(media < 5 || faltas > 25)
        {
            Console.WriteLine("Aluno Reprovado!");
        
        }else if(media < 9)
        {
            Console.WriteLine("Aluno Aprovado!");
        
        }else
        { 
            Console.WriteLine("Isso aí, jovem!");
        }
    }
}
}
