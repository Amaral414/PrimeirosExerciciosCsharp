using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    public class Geral
    {

        public static void TrocaDeItem(Personagem jogador, Personagem maquina)
        {
            /* - O usuário deve conseguir visualizar os dois inventários
             * - O usuário deve conseguir escolher o item que será comprado ou trocado
             * - O sistema deve mostrar os inventários atualizados após a troca
             */
            //byte _escolha;
            //_escolha = Geral.CriadorDeMenu("Troca <-- De --> Itens", "Mostrar Itens,Comprar,Vender,Trocar");

            VendaDeItem(jogador, maquina);
            Console.WriteLine(jogador);
            Console.WriteLine();
            Console.WriteLine(maquina);

            byte EscolhaDeItem()
            {
                byte item;
                Console.Write("Item n°: ");
                item = byte.Parse(Console.ReadLine());
                return item;
            };
            void MostrarIntens(Personagem ator1)
            {
                Console.WriteLine("==============================");
                Console.WriteLine($"Itens de: {ator1.Nome}\nDinheiro: {ator1.Dinheiro}");
                Console.WriteLine("--------------------");
                for (int i = 0; i < ator1.Inventario.Count; i++)
                {
                    Console.Write($"| {i + 1}: ");
                    Console.WriteLine(ator1.Inventario[i]);
                    Console.WriteLine("--------------------");
                }
                Console.WriteLine("==============================");
            }
            void VendaDeItem(Personagem comprador, Personagem vendedor)
            {
                byte _escolha = 0;
                do
                {
                    MostrarIntens(vendedor);
                    byte _item = EscolhaDeItem();
                    try
                    { //  O item numero x vai sair do inventario do vendedor
                        vendedor.Inventario.Remove(vendedor.Inventario[_item - 1]);
                        vendedor.Dinheiro += vendedor.Inventario[_item - 1].Preco;// O Dinheiro do vendedor vai receber o dinehiro dele mais o preço do item
                      //  O item numero x vai entrar no inventario do comprador
                        comprador.Inventario.Add(vendedor.Inventario[_item - 1]);
                        comprador.Dinheiro -= vendedor.Inventario[_item - 1].Preco;// O Dinheiro do comprador vai receber o dinehiro dele menos o preço do item
                    }
                    catch { Console.WriteLine("Saldo insuficiente!"); }
                    _escolha = CriadorDeMenu("Comprar outro item?", "Sim,Não");

                } while( _escolha != 2 );
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
