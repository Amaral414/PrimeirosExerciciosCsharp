using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjetoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.BackgroundColor = ConsoleColor.Green;
            ContaBancaria ContaBancaria = Cadastro();
            for (bool i = true; i == true;)
            {
                int _escolha = CriadorDeOpcoes("O que deseja fazer?", "Sacar,Depositar,Visualizar dados,Sair");

                switch (_escolha)
                {
                    case 1:
                        Console.WriteLine("Qual valor deseja sacar");
                        double _valor = double.Parse(Console.ReadLine());
                        ContaBancaria.Saque(_valor);
                        break;
                    case 2:
                        Console.WriteLine("Qual valor deseja depositar");
                        _valor = double.Parse(Console.ReadLine());
                        ContaBancaria.Saque(_valor);
                        break;
                    case 3:
                        Console.WriteLine($""ContaBancaria.Titular+ContaBancaria.Saldo+ContaBancaria.Numero);
                        break;
                    case 4:
                        i = false;
                        break;
                }
            }
        }
        static ContaBancaria Cadastro()
        {
            Random random = new Random();
            Console.WriteLine("====== Cadastro ======");
            Console.Write("Nome: ");
            string _nome = Console.ReadLine();
            Console.WriteLine("Deposito inicial (s/n)? ");
            char _escolha = char.Parse(Console.ReadLine());
            int _numeroDaConta = random.Next();
            ContaBancaria _contaBancaria = new ContaBancaria(_numeroDaConta, _nome, 0.0);

            if (_escolha == 'S' || _escolha == 's')
            {
                Console.Write("Valor do depósito: ");
                double _depositoInicial = Console.Read();
                _contaBancaria.Deposito(_depositoInicial);
            }

            return _contaBancaria;
        }

        static int CriadorDeOpcoes(string titulo, string opcoes)
        {
            int _escolha;
            string[] _opcoes = opcoes.Split(",");

            Console.WriteLine(titulo);
            for (int i = 0; i < _opcoes.Length; i++)
            {
                Console.WriteLine($"{1 + i} - {_opcoes[i]}");
            }
            Console.Write("R: ");
            _escolha = int.Parse(Console.ReadLine());

            return _escolha;
        }

    }
}