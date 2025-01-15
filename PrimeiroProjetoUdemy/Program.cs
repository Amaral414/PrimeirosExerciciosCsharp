using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PrimeiroProjetoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicios();
        }

        static void Exercicios()
        {
            for (bool i = true; i == true;)
            {
                int opc = CriadorDeOpcoes("Exercicio 1,Exercicio 2,Exercicio 3,Exercicios 4,Sair");
                switch (opc)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        i = false;
                        break;
                }
            }
            void Exercicio1()
            {
                /*  Exercícios utilizando apenas conceitos
                 *  básicos da linguagem C#:
                 */
                Console.Write("====== Exercício 1 ======\n");
                Console.Write("Nome do produto: ");
                string _nomeProduto1 = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double _precoProduto = double.Parse(Console.ReadLine());
                Console.Write("Quantidade em estoque: ");
                byte _quantidadeEmEstoque = byte.Parse(Console.ReadLine()); 

                Console.WriteLine($"\nProduto {_nomeProduto1} cadastrado com sucesso!");
                Console.WriteLine($"Preço: {_precoProduto}");
                Console.WriteLine($"Quantidade: {_quantidadeEmEstoque}\n");
                Console.WriteLine("Precione ENTER...");
                Console.ReadLine();
            }
            void Exercicio2()
            {
                /*  Exercicio utilizando estruturas de condição
                 *  if e else da linguagem C#:
                 */
                Console.WriteLine("\n====== Exercícios 2 ======\n");
                Console.Write("Digite seu nome: ");
                string _nome = Console.ReadLine();
                Console.Write("Digite sua idade: ");
                byte _idade = byte.Parse(Console.ReadLine());

                if (_idade >= 18)
                {
                    Console.WriteLine("\nNessa idade você pode: ");                    
                    Console.WriteLine("- Tirar a carteira de motorista");                    
                    Console.WriteLine("- Se alistar");                    
                    Console.WriteLine("- Abrir uma conta");                    
                    Console.WriteLine("E muitas outras coisas\n");
                    Console.WriteLine("Precione ENTER...");
                    Console.ReadLine();
                }
                else if(_idade >= 15)
                {
                    Console.WriteLine("\nNessa idade você deve: ");
                    Console.WriteLine("- Se preparar para o ENEM");
                    Console.WriteLine("- Começar um técnico");
                    Console.WriteLine("- Ser jovem aprendiz\n");
                    Console.WriteLine("Precione ENTER...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Nessa idade você deve apenas obedecer seus pais kkkkkkk\n");
                    Console.WriteLine("Precione ENTER...");
                    Console.ReadLine();
                }
            }
            void Exercicio3()
            {
                /*  Exercicio utilizando laços de repetição while e 
                 *  for da linguagem C#
                 */
                Console.WriteLine("\nContando com for:");
                for (byte i = 1; i < 5; i++)
                {
                    if (i > 1)
                    {
                        Console.WriteLine($"{i} vezes");
                    }
                    else
                    {
                        Console.WriteLine($"Repetindo {i} vez");
                    }
                }
                Console.WriteLine("Precione ENTER...");
                Console.ReadLine();

            }
            void Exercicio4()
            {
                Produto _produto = new Produto();
                Console.Write("Nome do produto: ");
                _produto.Nome = Console.ReadLine();
                Console.Write("Preço do Produto: ");
                _produto.Preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade em estoque: ");
                _produto.Quantidade = int.Parse(Console.ReadLine());

                for (bool i = true; i == true;)
                {
                    Console.WriteLine("1- Ver dados\n2- Adicionar\n3- Remover");
                    int opc = int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine(_produto);
                            ;
                            break;
                        case 2:
                            Console.Write("Quantidade: ");
                            int _quantidade = int.Parse(Console.ReadLine());
                            _produto.AdicionarProdutos(_quantidade);
                            break;
                        case 3:
                            Console.Write("Quantidade: ");
                            int _quantidade2 = int.Parse(Console.ReadLine());
                            _produto.RemoverProduto(_quantidade2);
                            break;
                        case 4:
                            i = false;
                            break;
                    }
                }
                Console.WriteLine("Precione ENTER...");
                Console.ReadLine();
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