using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    internal class Cliente
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private int Cpf { get; set; }
        private string Email { get; set; }
        public string Endereco { get; set; }

        public Cliente(int id, string nome, int cpf, string email, string endereco)
        {
            Nome = nome;
            Id = id;
            Cpf = cpf;
            Email = email;
            Endereco = endereco;
        }

        public static Cliente Cadastro(int id)
        {

            Random _random = new Random();
            int _numeroDaConta = _random.Next(1000, 2001);

            Console.WriteLine($"Conta numero {_numeroDaConta}");
            Console.Write("Nome: ");
            string _nome = Console.ReadLine();
            Console.Write("CPF (apenas números): ");
            int _cpf = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string _email = Console.ReadLine();
            Console.Write("Email: ");
            string _endereco = Console.ReadLine();

            Cliente _cliente = new Cliente(id, _nome, _cpf, _email, _endereco);

                return _cliente;
        }
    }
}
