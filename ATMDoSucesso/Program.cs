using System;

namespace ATMDoSucesso
{
    class Program
    {
        static void Main(string[] args)
        {
               int [] cedulas = {1,2,5,10,20,50,100};
                
                System.Console.WriteLine("Insira o valor desejado kkkkkkk vou roubar tudo");

                int valor = int.Parse(Console.ReadLine());   

                for (int i =cedulas.Length -1; i>= 0 ;i--)
                {
                    int qntdCedulas = valor / cedulas[i];
                    int sobra = valor % cedulas[i];
                    valor = sobra;

                    if(qntdCedulas != 0)
                    {
                        Console.WriteLine($"Você conseguiu roubar {qntdCedulas} nota(s) de {cedulas[i]}");
                    }
                }
        }
    }
}
