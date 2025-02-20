using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    public class Geral
    {
        public static void VendaDeItem(Personagem comprador, Personagem vendedor, Item item)
        {
            comprador.Inventario.Add(item);
            comprador.Dinheiro -= item.Preco;

            vendedor.Inventario.Remove(item);
            vendedor.Dinheiro += item.Preco;

        }
        public static int CriadorDeMenu(string titulo, string opcoes)
        {
            //  Se o parâmetro 'opcoes' receber null, aparecerá apenas o título
            int _escolha = 0;

            Console.WriteLine($"{titulo}:");
            if (opcoes != null)
            {
                string[] _opcoes = opcoes.Split(",");
                for (int i = 0; i < _opcoes.Length; i++)
                {
                    Console.WriteLine($"{1 + i} - {_opcoes[i]}");
                }
                Console.Write("R: ");
                _escolha = int.Parse(Console.ReadLine());
                LimparConsole(false);
            }

            return _escolha;
        }
        public static void LimparConsole(bool op)
        {
            if (op)
            {
                Console.WriteLine("Precione ENTER...");
                Console.ReadLine();
            }
            Console.Clear();
        }

    }
}
