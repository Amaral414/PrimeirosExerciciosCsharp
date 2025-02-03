using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    internal class Banco
    {
        private static List<Cliente> ListaDeClientes = new List<Cliente>();
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
            //  Menu 1:
            string _listaDeOpcoes;
            string _titulo;
            int _retornoDeMenu = 0;
            int _menu = 1;
            int opcao = 0;

            do
            {
                if (_menu == 1)
                {
                    _titulo = "Inicio";
                    _listaDeOpcoes = "Entrar,Cadastrar,Sair";
                    opcao = CriadorDeMenu(_titulo, _listaDeOpcoes);
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Entrando...");
                            break;
                        case 2:
                            Cadastro();
                            break;
                        case 3:
                            _retornoDeMenu = 4;
                            break;
                    }
                }
                if (_menu == 2)
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
            Console.Write("CPF (apenas números): ");
            long _cpf = long.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string _email = Console.ReadLine();
            Console.Write("Endereço: ");
            string _endereco = Console.ReadLine();

            Cliente _cliente = new Cliente(1, _nome, _cpf, _email, _endereco);
            ListaDeClientes.Add(_cliente);

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
            for (int i = 0; i < ListaDeClientes.Count; i++)
            {
                Console.WriteLine($"Cliente {i + 1}: {ListaDeClientes[i].Nome}");
            }
            LimparConsole(true);
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
            //  Dados de entrada do login:
            Console.WriteLine("Número da conta: ");
            int _numeroDaConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Senha (4 digitos): ");
            int _senha = int.Parse(Console.ReadLine());

            //  Dados para validação:
            bool _validacao;

            // Para cada ( _cliente na ListaDeCliente ){ faça }
            foreach (Cliente _cliente in ListaDeClientes)
            {

            }

            /*  Criar uma lógica para que seja percorrida toda
             *  a lista até que encontra o usuário com o nome
             *  que bata com o do login, depois disso, precisará
             *  que a senha do usuário seja igual a senha da lista
             */
            if (_numeroDaConta == 0)
            {

            }
            ListaDeClientes = new List<Cliente>();

            return false;
        }
    }
}
