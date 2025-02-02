﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public static int OpcoesDoMenu(int menu, int opcao)
        {
            int _retornoDeMenu = 0;

            if (menu == 1)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Entrando...");
                        break;
                    case 2:
                        Cadastro();
                        break;
                    case 3:
                        ListarClientes();
                        break;
                }
            }
            else if (menu == 2)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
       
            return _retornoDeMenu;

        }
        public static void Cadastro()
        {
            //  Lógica de cadastro (Como o nome diz);

            Random _random = new Random();
            int _numeroDaConta = _random.Next(1000, 2001);
            CriadorDeMenu("Cadastro",null);
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
        public static void Entrar()
        {
            Console.WriteLine("Número da conta: ");
            int _numeroDaConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Senha (4 digitos): ");
            int _senha = int.Parse(Console.ReadLine());

            /*  Criar uma lógica para que seja percorrida toda
             *  a lista até que encontra o usuário com o nome
             *  que bata com o do login, depois disso, precisará
             *  que a senha do usuário seja igual a senha da lista
             */
            if (_numeroDaConta)
            {
                
            }

            ListaDeClientes = new List<Cliente>();
        }
    }
}
