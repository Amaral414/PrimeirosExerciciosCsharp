using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public int NumeroDaConta { get; private set; }
        public double ValorEmConta { get; private set; }

        public Cliente(string nome, int numeroDaConta, double valorEmConta)
        {
            Nome = nome;
            NumeroDaConta = numeroDaConta;
            ValorEmConta = valorEmConta;
        }
        public Cliente() { }

        public static Cliente CadastrarCliente()
        {
            Random random = new Random();
            double _valorEmConta = 0.0;

            Console.Write("\nNome: ");
            string _nome = Console.ReadLine();
            int _numeroDaConta = random.Next(1, int.MaxValue);
            Console.WriteLine($"Numero da conta: {_numeroDaConta}");
            Console.Write("Deseja fazer um depósito inicial (s/n)? ");
            char _escolha = char.Parse(Console.ReadLine());

            if (_escolha == 's' || _escolha == 'S')
            {
                Console.Write("Valor para depósito: ");
                _valorEmConta = double.Parse(Console.ReadLine());
            }

            return new Cliente(_nome, _numeroDaConta, _valorEmConta);
        }
        public void Dados()
        {
            Console.WriteLine(Nome);
        }

    }
}
