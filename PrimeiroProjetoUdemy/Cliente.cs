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
        private long Cpf { get; set; }
        private string Email { get; set; }
        public string Endereco { get; set; }

        public Cliente(int id, string nome, long cpf, string email, string endereco)
        {
            Nome = nome;
            Id = id;
            Cpf = cpf;
            Email = email;
            Endereco = endereco;
        }

    }
}
