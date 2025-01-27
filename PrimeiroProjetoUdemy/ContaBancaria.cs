using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private  set; }
        
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this (numero, titular)
        {
            Deposito(depositoInicial);
        }
        
        public ContaBancaria() { }
        
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }
        public void Cadastro()
        {
            

        }
        public override string ToString()
        {
            return $"Numero da conta: {Numero}" +
                $"\nNome: {Titular}" +
                $"\nSaldo: {Saldo}";
        }
    }
}
