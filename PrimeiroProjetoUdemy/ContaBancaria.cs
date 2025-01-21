using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    internal class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public ContaBancaria() { }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }
    }
}
