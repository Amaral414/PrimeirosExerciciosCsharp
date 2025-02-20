using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    public class Geral
    {
        
        public static void TrocaDeItem(Personagem ator1, Personagem ator2)
        {
            /* - Essa função será utilizada para, sempre que houver alguma troca de item
             * (seja troca ou venda) essa função será chamada
             * - Mostrar os itens do inventáriodos dois personagens
             * - Se for dar um item terá que aparecer o inventário do ator1
             * - Se for receber aparecerá o inventário do ator2.
             */
            byte _escolha;

            _escolha = Geral.CriadorDeMenu("Troca <-- De --> Itens", "Mostrar Itens,Comprar,Vender,Trocar");




            void MostrarIntens()
            {
                foreach (Item item in ator1.Inventario)
                {
                    Console.WriteLine($"{ator1.Inventario[1]}");
                }
            }
            void VendaDeItem(Personagem comprador, Personagem vendedor, Item item)
            {
                comprador.Inventario.Add(item);
                comprador.Dinheiro -= item.Preco;

                vendedor.Inventario.Remove(item);
                vendedor.Dinheiro += item.Preco;

            }
        }
        public static byte CriadorDeMenu(string titulo, string opcoes)
        {
            //  Se o parâmetro 'opcoes' receber null, aparecerá apenas o título
            byte _escolha = 0;

            Console.WriteLine($"{titulo}:");
            if (opcoes != null)
            {
                string[] _opcoes = opcoes.Split(",");
                for (int i = 0; i < _opcoes.Length; i++)
                {
                    Console.WriteLine($"{1 + i} - {_opcoes[i]}");
                }
                Console.Write("R: ");
                _escolha = byte.Parse(Console.ReadLine());
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
