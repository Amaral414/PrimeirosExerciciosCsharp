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
            Item item1 = new Item("Livro", 3.5, 1.5, 1);
            Item item2 = new Item("Espada", 4.2, 1.5, 1);
            Item item3 = new Item("Botas", 5.4, 1.5, 1);
            Item item4 = new Item("escudo", 4.1, 1.5, 1);

            p1.Inventario.Add(item1);
            p1.Inventario.Add(item2);
            p2.Inventario.Add(item3);
            p2.Inventario.Add(item4);

            int escolha = 0;
            
            while(escolha != 4)
            {
                escolha = Geral.CriadorDeMenu("INICIO", "Comprar,Vender,Dados,Sair");
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("comprando Item");
                        Geral.VendaDeItem(p1, p2, p2.Inventario[0]);
                        break;
                    case 2:
                        Console.WriteLine("vendendo Item");
                        Geral.VendaDeItem(p2, p1, p1.Inventario[0]);
                        break;
                    case 3:

                        Console.WriteLine(p1.Dinheiro);
                        Console.WriteLine(p2.Dinheiro);
                        break;
                    case 4:
                        break;
                }
            }
            
        }
    }
}