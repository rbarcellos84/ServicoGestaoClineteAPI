using Dapper;
using ServicoGestaoClinete.Data.Configurations;
using ServicoGestaoClinete.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoGestaoClinete.Data.Repositories
{
    public class ClienteRepository
    {
        public void Insert(Cliente cliente)
        {
            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                //executa comando no sql
                connection.Execute("Sp_Insert_Cliente", new
                {
                    @Nome = cliente.Nome,
                    @Cpf = cliente.Cpf,
                    @Telefone = cliente.Telefone,
                    @Email = cliente.Email,
                    @Profissao = cliente.Profissao,
                    @DataNascimento = cliente.DataNascimento,
                    @Logradouro = cliente.Logradouro,
                    @Numero = cliente.Numero,
                    @Bairro = cliente.Bairro,
                    @Municipio = cliente.Municipio,
                    @Estado = cliente.Estado,
                    @ComoConheceu = cliente.ComoConheceu,
                    @Observacao = cliente.Observacao
                }, commandType: CommandType.StoredProcedure);
            }

        }
        public void Update(Cliente cliente)
        {
            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                //executa comando no sql
                connection.Execute("Sp_Update_Cliente", new
                {
                    @Nome = cliente.Nome,
                    @Cpf = cliente.Cpf,
                    @Telefone = cliente.Telefone,
                    @Email = cliente.Email,
                    @Profissao = cliente.Profissao,
                    @DataNascimento = cliente.DataNascimento,
                    @Logradouro = cliente.Logradouro,
                    @Numero = cliente.Numero,
                    @Bairro = cliente.Bairro,
                    @Municipio = cliente.Municipio,
                    @Estado = cliente.Estado,
                    @ComoConheceu = cliente.ComoConheceu,
                    @Observacao = cliente.Observacao,
                    @IdCliente = cliente.IdCliente
                }, commandType: CommandType.StoredProcedure);
            }
        }
        public void Delete(Guid idCliente)
        {
            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                //executa comando no sql
                connection.Execute("Sp_Delete_Cliente", new
                {
                    @IdCliente = idCliente
                }, commandType: CommandType.StoredProcedure);
            }
        }
        public Cliente? GetById(Guid idCliente)
        {
            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                //executa comando no sql
                return connection.Query<Cliente>("Sp_SelectId_Cliente", new
                {
                    @IdCliente = idCliente
                }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public List<Cliente> GetAll()
        {
            //conectar com o banco
            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                //executa comando no sql
                return connection.Query<Cliente>("Sp_SelectAll_Cliente", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
