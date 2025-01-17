using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjetoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (bool i = true; i == true;)
            {
                int _escolha = CriadorDeOpcoes("O que deseja fazer?", "Fazer cadastro,Visualizar dados,Sair");
                switch (_escolha)
                {
                    case 1:
                        Cliente cliente1 = Cliente.CadastrarCliente();
                        break;
                    case 2:
                        Cliente.Dados();
                        break;
                    case 3:
                        i = false;
                        break;
                }
            }
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