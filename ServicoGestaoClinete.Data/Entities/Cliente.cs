using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoGestaoClinete.Data.Entities
{
    public class Cliente
    {
        private DateTime? dataCadastro;

        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string ComoConheceu { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public Cliente()
        {

        }

        public Cliente(Guid idCliente)
        {
            IdCliente = idCliente;
        }

        public Cliente(string nome, string cpf, string telefone, string email, string profissao, DateTime dataNascimento, string logradouro, int numero, string bairro, string municipio, string estado, string comoConheceu, string observacao)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Profissao = profissao;
            DataNascimento = dataNascimento;
            Logradouro = logradouro;
            if (numero < 0)
                Numero = 0;
            else
                Numero = numero;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
            ComoConheceu = comoConheceu;
            Observacao = observacao;
        }

        public Cliente(Guid idCliente, string nome, string cpf, string telefone, string email, string profissao, DateTime dataNascimento, string logradouro, int numero, string bairro, string municipio, string estado, string comoConheceu, string observacao)
        {
            IdCliente = idCliente;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Profissao = profissao;
            DataNascimento = dataNascimento;
            Logradouro = logradouro;
            if (numero < 0)
                Numero = 0;
            else
                Numero = numero;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
            ComoConheceu = comoConheceu;
            Observacao = observacao;
        }
    }
}
