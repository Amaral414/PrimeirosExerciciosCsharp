using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjetoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OpcoesDeExercicios();
        }

        static void OpcoesDeExercicios()
        {
            for (bool i = true; i == true;)
            {
                int opc = CriadorDeOpcoes("Exercicio Sequencial,Exercicio Condicional,Exercicio de repetição,Exercicios com Classe,Sair");
                switch (opc)
                {
                    case 1:
                        ExerciciosSequenciais();
                        break;
                    case 2:
                        ExerciciosCondicionais();
                        break;
                    case 3:
                        ExerciciosDeRepeticao();
                        break;
                    case 4:
                        ExerciciosComClasses();
                        break;
                    case 5:
                        i = false;
                        break;
                }
            }

            void ExerciciosSequenciais()
            {
                for (bool i = true; i == true;)
                {
                    switch (CriadorDeOpcoes("Exercício 1,Exercício 2,Exercício 3"))
                    {
                        case 1:
                            PrimeiroExercicio();
                            break;
                        case 2:
                            SegundoExercicio();
                            break;
                        case 3:
                            Console.WriteLine("Não há nada aqui");
                            i = false;
                            break;
                    }
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
            void ExerciciosCondicionais()
            {

            }
            void ExerciciosDeRepeticao()
            {

            }
            void ExerciciosComClasses()
            {
                void Exercicios1()
                {
                    /* Fazer um programa para ler os dados de um produto em estoque, 
                     * em seguida mostrar os dados do produto, realizar uma entrada no
                     * estoque e mostrar novamente os dados e realizar uma
                     * saida no estoque e mostrar novamente os dados... 
                     */




                }


            }
            int CriadorDeOpcoes(string opcoes)
            {
                int _escolha;
                string[] _opcoes = opcoes.Split(",");

                for (int i = 0; i < _opcoes.Length; i++)
                {
                    Console.WriteLine($"{1 + i} - {_opcoes[i]}");
                }
                Console.Write("R: ");
                _escolha = int.Parse(Console.ReadLine());

                return _escolha;
            }


        }
    }
}