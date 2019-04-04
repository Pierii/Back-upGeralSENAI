using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("|=====================|");
            Console.WriteLine("|-------TABUADA-------|");
            Console.WriteLine("|=====================|");
            Console.WriteLine("");
            Console.WriteLine("Aqui você encontra a tabuada que você quiser!!!");
            Console.WriteLine("");
            Console.WriteLine("_______________________");
            Console.WriteLine("");
            
            int cont = 0;
            bool replay = true;

            while (replay)
            {
                Console.WriteLine("Insira o número desejado:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------|");
            
            while (cont <=10)
            {
                Console.WriteLine(num+ "X" +cont+ "="+num*cont);    
                cont++;
            }

                Console.WriteLine("Quer tentar outra tabuada?");
                string resposta = Console.ReadLine();
                
                if (replay = resposta.Equals("sim")){
                    replay = true;    
                }
                else{
                    replay = false;
                }
        }
    }
}
}
