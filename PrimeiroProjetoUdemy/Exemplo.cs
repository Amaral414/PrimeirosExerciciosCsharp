using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    internal class Exemplo
    {

            //private static List<Cliente> ListaDeClientes = new List<Cliente>();
            private string Nome { get; set; }
            private int Cnpj { get; set; }
            private string NumeroDeContato { get; set; }
            public string Endereco { get; set; }

            public static int CriadorDeMenu(string titulo, string opcoes)
            {
                //  Se o parâmetro 'opcoes' receber null, aparecerá apenas o título
                int _escolha = 0;

                Console.WriteLine($"{titulo}:");
                if (opcoes != null)
                {
                    string[] _opcoes = opcoes.Split(",");
                    for (int i = 0; i < _opcoes.Length; i++)
                    {
                        Console.WriteLine($"{1 + i} - {_opcoes[i]}");
                    }
                    Console.Write("R: ");
                    _escolha = int.Parse(Console.ReadLine());
                    LimparConsole(false);
                }

                return _escolha;
            }
            public static int OpcoesDoMenu()
            {
                //  Vriáveis do ambiente
                string _listaDeOpcoes;
                string _titulo;
                int _retornoDeMenu = 0;
                bool validacao = false;
                int opcao = 0;

                //  Clientes adicionados a lista
                //Cliente cliente1 = new Cliente(1, 123, 1554, "Gabriel", 04589273098, "gab@hotmail.com", "Rua da bandeira");
                //Cliente cliente2 = new Cliente(2, 213, 1112, "Alecsandra", 901528976, "alecs@hotmail.com", "Br 153");
                //Cliente cliente3 = new Cliente(3, 321, 2547, "Carlos", 3128129321, "carlinhos@hotmail.com", "Br 153");
                //ListaDeClientes.Add(cliente1);
                //ListaDeClientes.Add(cliente2);
                //ListaDeClientes.Add(cliente3);


                do
                {
                    _titulo = "Inicio";
                    _listaDeOpcoes = "Entrar,Cadastrar,Sair";
                    opcao = CriadorDeMenu(_titulo, _listaDeOpcoes);
                    switch (opcao)
                    {
                        case 1:
                            validacao = Entrar();
                            break;
                        case 2:
                            Cadastro();
                            break;
                        case 3:
                            _retornoDeMenu = 4;
                            break;
                    }

                    if (validacao)
                    {
                        _titulo = "Inicio";
                        _listaDeOpcoes = "Entrar,Cadastro,Clientes cadastrados,Sair";
                        opcao = CriadorDeMenu(_titulo, _listaDeOpcoes);
                        switch (opcao)
                        {
                            case 1:
                                ListarClientes();
                                break;
                            case 2:
                                Console.WriteLine("Analisando dados...");
                                break;
                            case 3:
                                Console.WriteLine("Analisando pits top");
                                break;
                            case 4:
                                Console.WriteLine("saindo");
                                break;
                        }
                    }
                }
                while (opcao != 4);


                return _retornoDeMenu;

            }
            public static void Cadastro()
            {
                //  Lógica de cadastro (Como o nome diz);

                Random _random = new Random();
                int _numeroDaConta = _random.Next(1000, 2001);
                CriadorDeMenu("Cadastro", null);
                Console.WriteLine($"\nConta numero {_numeroDaConta}");
                Console.Write("Nome: ");
                string _nome = Console.ReadLine();
                Console.Write("Senha: ");
                int _senha = int.Parse(Console.ReadLine());
                Console.Write("CPF (apenas números): ");
                long _cpf = long.Parse(Console.ReadLine());
                Console.Write("Email: ");
                string _email = Console.ReadLine();
                Console.Write("Endereço: ");
                string _endereco = Console.ReadLine();

                //Cliente _clienteCadastrado = new Cliente(1, _senha, _numeroDaConta, _nome, _cpf, _email, _endereco);
                //ListaDeClientes.Add(_clienteCadastrado);

                Console.WriteLine($"\nCliente {_nome} criado com sucesso!\n");
                LimparConsole(true);
            }
            public static void ListarClientes()
            {

                /*  Lógica para fazer a lista de clientes;
                 *  Próximo passo é tentar pegar o nome dos usuários
                 *  que estão na lista e fazer eles aparecerem
                 *  no console write;  
                 */
                //for (int i = 0; i < ListaDeClientes.Count; i++)
                //{
                //    Console.WriteLine($"Cliente {i + 1}: {ListaDeClientes[i].Nome}");
                //}
                //LimparConsole(true);
            }
            public static void LimparConsole(bool op)
            {
                if (op)
                {
                    Console.WriteLine("Precione ENTER...");
                    Console.ReadLine();
                }
                Console.Clear();
            }
            public static bool Entrar()
            {
                bool _validacao = false;

                // Para cada ( _cliente na ListaDeCliente ){ faça }
                //foreach (Cliente _cliente in ListaDeClientes)
                //{
                //    //  Dados de entrada do login:
                //    Console.WriteLine("Número da conta: ");
                //    int _numeroDaConta = int.Parse(Console.ReadLine());
                //    Console.WriteLine("Senha (4 digitos): ");
                //    int _senha = int.Parse(Console.ReadLine());

                //    if (_cliente.NumeroDaConta == _numeroDaConta && _cliente.Senha == _senha)
                //    {
                //        _validacao = true;
                //        Console.WriteLine("Entrou!");
                //        break;
                //    }
                //}

                /*  Criar uma lógica para que seja percorrida toda
                 *  a lista até que encontra o usuário com o nome
                 *  que bata com o do login, depois disso, precisará
                 *  que a senha do usuário seja igual a senha da lista
                 */

                return _validacao;
            }
        
    }
}

