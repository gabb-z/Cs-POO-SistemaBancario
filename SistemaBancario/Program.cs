using System;
using System.Globalization;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Objeto - Conta
            ContaBancaria conta;

            //Entrada de Dados - Cadastro do Cliente
            Console.Write("Digite o número da conta: ");
            int nConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();

            //Opção - Depósito Inicial
            Console.Write("Haverá depósito inicial (s/n): ");
            char opcao = char.Parse(Console.ReadLine());

            //Condição - Depósito Inicial
            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Declarando Objeto - 3 Atributos
                conta = new ContaBancaria(nConta, nomeTitular, valorDeposito);

                //Saída de Dados
                Console.WriteLine($"\nDados da conta: {conta}");
            }
            else
            {
                conta = new ContaBancaria(nConta, nomeTitular);

                //Saída de Dados
                Console.WriteLine($"\nDados da conta: {conta}");
            }

            //Entrada de Dados - Depósito
            Console.Write("\nDigite um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);

            //Saída de Dados Atualizados - Valor após Depósito
            Console.WriteLine($"\nDados da conta atualizados: {conta}");

            //Entrada de Dados - Saque
            Console.Write("\nDigite um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            //Saída de Dados Atualizados - Valor após Saque
            Console.WriteLine($"\nDados da conta atualizados: {conta}");
        }
    }
}
