using System;

namespace PrimeiroProjetoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeiroExercicio();
        }

        public static void PrimeiroExercicio()
        {
            string _produto1 = "Computador";
            string _produto2 = "Mesa de Escritório";

            byte _idade = 24;
            int _codigo = 5290;
            char _genero = 'M';

            double _preco1 = 2100.0;
            double _preco2 = 650.50;
            double _medida = 53.234567;
            Console.WriteLine(" ====== EXERCÍCIO 1 ======");
            Console.WriteLine();
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{_produto1}, cujo preço é ${_preco1.ToString("F2")}");
            Console.WriteLine($"{_produto2}, cujo preço é ${_preco2.ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {_idade} anos de idade, código {_codigo} e gênero: {_genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {_medida}");
            Console.WriteLine($"Arredondado (três casas decimais) {_medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal {_medida.ToString("F3")}");

        }
    }
}