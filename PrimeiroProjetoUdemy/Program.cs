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
            Personagem jogador = new Personagem("Jogador", 100, 20.0);
            Personagem maquina = new Personagem("Maquina", 100, 20.0);
            Item item1 = new Item("Livro", 1.5, 1.5, 1);
            Item item2 = new Item("Espada", 2.0, 1.5, 1);
            Item item3 = new Item("Botas", 1.5, 1.5, 1);
            Item item4 = new Item("escudo", 3.0, 1.5, 1);
            jogador.Inventario.Add(item1);
            jogador.Inventario.Add(item2);
            jogador.Inventario.Add(item3);
            jogador.Inventario.Add(item4);
            maquina.Inventario.Add(item1);
            maquina.Inventario.Add(item2);
            maquina.Inventario.Add(item3);
            maquina.Inventario.Add(item4);

            Geral.TrocaDeItem(jogador, maquina);

        }
    }
}