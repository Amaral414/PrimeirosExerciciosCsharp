using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    public class Item
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Peso { get; set; }
        public byte Quantidade { get; set; }

        public Item(string nome, double preco, double peso, byte quantidade)
        {
            Nome = nome;
            Preco = preco;
            Peso = peso;
            Quantidade = quantidade;
        }
        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
