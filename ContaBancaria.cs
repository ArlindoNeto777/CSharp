using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace curso
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Titular = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial)
        {
            NumeroConta = numeroConta;
            Titular = nome;
            Depositar(depositoInicial);
        }

        public void Depositar(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Sacar(double saque)
        {
            Saldo = Saldo - saque - 5;
        }

        public override string ToString()
        {
            return "Conta "
            + NumeroConta
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }        
    }
}
