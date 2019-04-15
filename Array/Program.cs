using System;

namespace ArrayParOuImpar {
    class Program {
        static void Main (string[] args) {

            // int[] numeros = { 15, 15,15,15,15,15,15,15,15,15,15,15,15,15,15,15};
            
            // int impar = 0;

            // for (int i = 0; i <= 14; i++) {
            //     if (numeros[i] % 2 != 0) {
            //         impar++;
            //     }
            // }
            // Console.WriteLine ("Existem {0} meliantes ",impar);
             //     num [1] = 93;
             //     num [2] = 101;
             //     num [3] = 388;

//  --------------------------------------------------------------------------------------------------

            int[] numeros = new int [5];
            for (int i = 0; i <numeros.Length; i++)
            { 
                numeros[i] = int.Parse(Console.ReadLine());
            }

            foreach (var num in numeros)
            {
                System.Console.Write($"{num},");
            }
                
        }

    }
}
