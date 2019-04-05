using System;

namespace DadosGerais
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("Bem vindo ao calcula trecos!!!");
            Console.WriteLine("<=~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=>");
            Console.WriteLine("AVISO! INFORMAÇÕES INVÁLIDAS SERÃO DESCARTADAS, LOGO, IRÃO AFETAR O RESULTADO, ESCREVA COM ATENÇÃO!!!");
            Console.WriteLine("<+~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+>");


            int Homens = 0;
            int Mulheres = 0;
            
            int idadeHomem = 0;
            int idadeMulher = 0;

            float pesoHomem = 0;
            float pesoMulher = 0;

            for (int i = 0; i <4 ; i++)            
            {
            Console.WriteLine("Qual seu sexo? Masculino digite 1, Feminino digite 2!");
            int sexo = int.Parse(Console.ReadLine());
            Console.WriteLine("________________");
            
                if (sexo == 1)
                {                
                    Homens++;

                    Console.WriteLine("Qual sua idade?");
                    idadeHomem = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("________________");
                    
                    Console.WriteLine("Qual seu peso?");
                    pesoHomem = float.Parse(Console.ReadLine());

                    Console.WriteLine("________________");
                }
                else if (sexo == 2)
                {
                    Mulheres++;

                    Console.WriteLine("Qual sua idade?");
                    idadeMulher = int.Parse(Console.ReadLine());

                    Console.WriteLine("________________");
                    
                    Console.WriteLine("Qual seu peso?");
                    pesoMulher = float.Parse(Console.ReadLine());

                    Console.WriteLine("________________");
                }
                else
                {
                    Console.WriteLine("Você digitou alguma coisa errada!");
                }
             }

            float mediaIdadeHomens = idadeHomem/Homens;
            float mediaIdadeMulheres = idadeMulher/Mulheres;

            float mediaPesoHomens = pesoHomem/Homens;
            float mediaPesoMulheres = pesoMulher/Mulheres;

            Console.WriteLine("A quantidade de homens é de "+Homens);
            Console.WriteLine("A média da idade dos homens é de "+mediaIdadeHomens);
            Console.WriteLine("A média do peso dos homens é de "+mediaPesoHomens);

            Console.WriteLine("<=~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=>");

            Console.WriteLine("A quantidade de mulheres é de "+Mulheres);
            Console.WriteLine("A média da idade das mulheres é de "+mediaIdadeMulheres);
            Console.WriteLine("A média do peso das mulheres é de "+mediaPesoMulheres);

        }
    }
}