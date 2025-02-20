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
            Personagem p1 = new Personagem("Personagem 1", 10, 10.0);
            Personagem p2 = new Personagem("Personagem 2", 10, 10.0);

            Geral.TrocaDeItem(p1, p2);

        }
    }
}