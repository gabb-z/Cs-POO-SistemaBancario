using System;
using System.Globalization;

namespace SistemaBancario
{
    class ContaBancaria
    {
        //Valor Estático - Taxa de Saque
        static double TaxaSaque = 5.0;

        //Atributos da Classe - Cliente
        public int NumeroConta { get; private set; }
        public string NomeCliente  { get; set; }
        public double Saldo { get; private set; }

        //Construtor - 2 Atributos
        public ContaBancaria(int numeroConta, string nomeCliente)
        {
            NumeroConta = numeroConta;
            NomeCliente = nomeCliente;
        }

        //Construtor - 3 Atributos
        public ContaBancaria(int numeroConta, string nomeCliente, double saldo) : this(numeroConta, nomeCliente)
        {
            Saldo = saldo;
        }


        //Métodos da Classe - Depósito
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        //Métodos da Classe - Saque
        public void Saque(double valor)
        {
            Saldo -= valor + TaxaSaque;
        }

        //ToString
        public override string ToString()
        {
            return "\nConta: " + NumeroConta + ", Titular: " + NomeCliente + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
