using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    public class Personagem
    {
        public int Vida { get; set; }
        public double Dinheiro { get; set; }
        public Inventario Inventario { get; set; }

        public Personagem() { }
        public Personagem(int vida, double dinheiro, Inventario inventario) 
        {
            Vida = vida;
            Dinheiro = dinheiro;
            Inventario = inventario;
            Vida = vida;
        }
        public override string ToString()
        {
            return $"Vida: {Vida}\nDinheiro: {Dinheiro}\n";
        }

    }

    
}
