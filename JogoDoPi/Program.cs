using System;

namespace JogoDoPi
{
    class Program
    {
        static void Main(string[] args)
        {            
            for (int i =0; i <10; i++)
            {
                Console.WriteLine(((i % 4 != 0)? i.ToString() : "PI"));
            }
        }
    }
}
