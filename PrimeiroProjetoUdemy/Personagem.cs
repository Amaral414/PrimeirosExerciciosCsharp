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

        public Personagem() { }
        public Personagem(string nome, int vida, double dinheiro)
        {
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
