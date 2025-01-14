using System;

namespace PrimeiroProjetoUdemy
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstorque() 
        {
            double _valorTotal = Quantidade*Preco;

            return _valorTotal;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public override string ToString()
        {
            return "Produto: " + Nome
            + "\nPreço: " + Preco
            + "\nQuantidade: " + Quantidade
            + "\nPreço total: " + ValorTotalEmEstorque()+"\n";
            ;
        }
    }
}
