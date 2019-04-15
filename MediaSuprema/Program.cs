using System;

namespace MediaSuprema
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nome1 = new string [10];
            string[] nome2 = new string [10];
            int[] notaValor1 = new int [10];
            int[] notaValor2 = new int [10];
            
            System.Console.WriteLine("================================");
            System.Console.WriteLine("Bem vindo ao CalculaMédia 2.0");
            System.Console.WriteLine("================================");

            for (int i = 0; i <2; i++)
            {
            System.Console.WriteLine("================================");
            
            System.Console.WriteLine("Digite o nome do aluno:");
            nome1[i] = Console.ReadLine();
            
            System.Console.WriteLine("Digite o sobrenome do aluno:");
            nome2[i] = Console.ReadLine();

            System.Console.WriteLine("Digite a nota:");
            notaValor1[i] = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a segunda nota:");
            notaValor2[i] = int.Parse(Console.ReadLine());

            float soma = notaValor1[i] + notaValor2[i];
            float media = soma/2;
            
            System.Console.WriteLine("================================");
            System.Console.WriteLine("Aqui estão os resultados!!!");
            System.Console.WriteLine($"O aluno {nome1[i]} {nome2[i]} teve uma média de {media}");
            if (media >= 50)
            {
                System.Console.WriteLine("Parabéns, foi aprovado!!");
            }
            else
            {
                System.Console.WriteLine("Pô amigão, nn foi dessa vez");
            }
            }

        }
    }
}
