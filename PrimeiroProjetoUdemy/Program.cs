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
            Random random = new Random();
            ContaBancaria ContaBancaria;

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