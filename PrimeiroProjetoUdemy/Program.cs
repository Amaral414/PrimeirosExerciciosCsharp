using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjetoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrimeiroExercicio();
            //SegundoExercicio();
            OpcoesDeExercicios();


        }

        public static void OpcoesDeExercicios()
        {
            Console.WriteLine("Escolha o exercício que deseja ver");
            Console.WriteLine("1 - Exercicios sequenciais");
            Console.WriteLine("2 - Exercicios sla");
            Console.Write("R: ");

            int _opcao = int.Parse(Console.ReadLine());

            switch (_opcao)
            {
                case 1:
                    ExerciciosSequenciais();
                    break;
                case 2:
                    Console.WriteLine("Não há nada aqui...");
                    break;
            }

            void ExerciciosSequenciais()
            {
                Console.WriteLine("1 - Primeiro Exercicio");
                Console.WriteLine("2 - Segundo Exercicio");
                Console.WriteLine("3 - Terceiro Exercicio");
                Console.Write("R: ");
                int _opcao = int.Parse(Console.ReadLine());

                switch (_opcao)
                {
                    case 1:
                        PrimeiroExercicio();
                        break;
                    case 2:
                        SegundoExercicio();
                        break;
                    case 3:
                        Console.WriteLine("Não há nada aqui");
                        break;
                }

                void PrimeiroExercicio()
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
                void SegundoExercicio()
                {
                    string _nomeCompleto;
                    int _quartos;
                    double _preco;
                    string _informacoes;

                    Console.Write("Nome completo: ");
                    _nomeCompleto = Console.ReadLine();
                    Console.Write("Quantos quartos tem sua casa: ");
                    _quartos = int.Parse(Console.ReadLine());
                    Console.Write("Digite o preço de um produto: ");
                    _preco = double.Parse(Console.ReadLine());
                    Console.Write("Seu ultimo nome, idade e altura: ");
                    _informacoes = Console.ReadLine();

                    string[] _sep = _informacoes.Split(' ');
                    string _ultimoNome = _sep[0];
                    int _idade = int.Parse(_sep[1]);
                    double _altura = double.Parse(_sep[2]);

                    Console.WriteLine(_nomeCompleto);
                    Console.WriteLine(_quartos);
                    Console.WriteLine(_preco);
                    Console.WriteLine(_ultimoNome);
                    Console.WriteLine(_idade);
                    Console.WriteLine(_altura);

                }
            }
        }
    }
}