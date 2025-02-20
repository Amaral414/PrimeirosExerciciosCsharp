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
            Inventario inventario = new Inventario();
            Personagem p1 = new Personagem(10,10.0,inventario);
            Personagem p2 = new Personagem(10,10.0,inventario);

            Console.WriteLine(p1);
            Console.WriteLine(p1.ToString);
            Console.WriteLine(p1.Vida);
            Console.WriteLine(p1.Dinheiro);
            Console.WriteLine(p1.Inventario);
            Console.WriteLine("");
            Console.WriteLine(p2.Inventario);
            Console.WriteLine(p2.Dinheiro);
            Console.WriteLine(p2.Vida);




        }
    }
}