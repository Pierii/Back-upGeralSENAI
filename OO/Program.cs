using System;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a $afe Bank");

            ContaCorrente conta1 =  new ContaCorrente();

            System.Console.WriteLine("Digite o titular");
            conta1.titular = Console.ReadLine();
            System.Console.WriteLine("Digite o número da agência");
            conta1.agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número da conta");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            conta1.Depositar(1000);
            System.Console.WriteLine("Deseja sacar quanto?");
            double valor = double.Parse(Console.ReadLine());
            bool resultado = conta1.Sacar(valor);

            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine($"Titular {conta1.titular}");
            System.Console.WriteLine($"Agência {conta1.agencia}");
            System.Console.WriteLine($"Numero da conta {conta1.numeroConta}");
            System.Console.WriteLine($"Saldo {conta1.saldo}");
            System.Console.WriteLine($"Resultado do saque {resultado}");
            System.Console.WriteLine("-----------------------------------------");


            ContaCorrente conta2 =  new ContaCorrente();
            System.Console.WriteLine("Digite o titular");
            conta2.titular = Console.ReadLine();            
            System.Console.WriteLine("Digite o número da agência");
            conta2.agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número da conta");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            conta2.Depositar(3000);
            System.Console.WriteLine("Deseja sacar quanto?");
            double valor2 = double.Parse(Console.ReadLine());
            bool resultado2 = conta1.Sacar(valor2);

            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine($"Titular {conta2.titular}");
            System.Console.WriteLine($"Agência {conta2.agencia}");
            System.Console.WriteLine($"Numero da conta {conta2.numeroConta}");
            System.Console.WriteLine($"Saldo {conta2.saldo}");
            System.Console.WriteLine($"Resultado do saque {resultado2}");
            System.Console.WriteLine("-----------------------------------------");

            bool resultadoTransferencia = true;
            do{

            System.Console.WriteLine("Quanto deseja transferir da conta1 para a conta2");
            double valorTransferencia = double.Parse(Console.ReadLine());
            resultadoTransferencia = conta1.Transferir(valorTransferencia, conta2);
            }while(resultadoTransferencia != true);

            System.Console.WriteLine($"-----------Resultado após a  transferencia-----------");
            System.Console.WriteLine($"Saldo conta1 : {conta1.saldo}");
            System.Console.WriteLine($"Saldo conta2 : {conta2.saldo}");
        }
    }
}
