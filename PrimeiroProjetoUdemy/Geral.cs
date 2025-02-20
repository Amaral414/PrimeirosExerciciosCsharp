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

    }
}
