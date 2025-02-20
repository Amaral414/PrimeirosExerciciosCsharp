using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public double Dinheiro { get; set; }
        public List<Item> Inventario { get; set; } = new List<Item>();
        Item item1 = new Item("Livro", 3.5, 1.5, 1);
        Item item2 = new Item("Espada", 4.2, 1.5, 1);
        Item item3 = new Item("Botas", 5.4, 1.5, 1);
        Item item4 = new Item("escudo", 4.1, 1.5, 1);



        public Personagem() { }
        public Personagem(string nome, int vida, double dinheiro)
        {
            Inventario.Add(item1);
            Inventario.Add(item2);
            Inventario.Add(item3);
            Inventario.Add(item4);
            Nome = nome;
            Vida = vida;
            Dinheiro = dinheiro;
            Vida = vida;
        }
        public override string ToString()
        {
            string retorno = $"Vida: {Vida}\nDinheiro: {Dinheiro}";

            return retorno;
        }
    }
}
