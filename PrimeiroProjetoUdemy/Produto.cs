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
            double _valor = 10.0;

            return _valor;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        public void DadosDoProduto() 
        {
            Console.WriteLine("========================");
            Console.WriteLine("Produto: " + Nome);
            Console.WriteLine("Preço: " + Preco);
            Console.WriteLine("Quantidade: " + Quantidade);
            Console.WriteLine("========================");
        }
    }
}
