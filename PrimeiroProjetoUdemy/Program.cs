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
            Item item1 = new Item("Escudo", 5.0, 1.5, 1);
            Item item2 = new Item("Espada", 7.5, 1.5, 1);
            Item item3 = new Item("Adaga", 7.5, 1.5, 1);
            Item item4 = new Item("Botas", 10.0, 1.5, 1);
            Item item5 = new Item("Capa", 5.0, 1.5, 1);
            Item item6 = new Item("Peitoral", 5.0, 1.5, 1);
            jogador.Inventario.Add(item1);
            jogador.Inventario.Add(item2);
            jogador.Inventario.Add(item3);
            maquina.Inventario.Add(item4);
            maquina.Inventario.Add(item5);
            maquina.Inventario.Add(item6);

            Geral.TrocaDeItem(jogador, maquina);

        }
    }
}