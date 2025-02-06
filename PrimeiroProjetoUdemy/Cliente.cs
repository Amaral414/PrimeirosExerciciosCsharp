using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjetoUdemy
{
    internal class Cliente
    {
        public int Id { get; set; }
        public int NumeroDaConta { get; set; }
        public int Senha { get; set; }
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        public Cliente(int id,int numeroDaConta,int senha, string nome, long cpf, string email, string endereco)
        {
            Id = id;
            Nome = nome;
            NumeroDaConta = numeroDaConta;
            Senha = senha;
            Cpf = cpf;
            Email = email;
            Endereco = endereco;
        }

    }
}
