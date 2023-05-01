using ServicoGestaoClinete.API.Model;
using ServicoGestaoClinete.Data.Entities;
using ServicoGestaoClinete.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ServicoGestaoClinete.API.Controllers
{
    //Patros Rest (Post cadastro, Put edição, Delete exclusãoe e Get consulta)
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        [HttpPost]
        public IActionResult Post(ClientePostModel model)
        {
            //cadastro de funcionario
            try
            {
                Cliente cliente = new Cliente(model.Nome, model.Cpf, model.Telefone, model.Email, model.Profissao, model.DataNascimento, model.Logradouro, model.Numero, model.Bairro, model.Municipio, model.Estado, model.ComoConheceu, model.Observacao);
                ClienteRepository clienteRepository = new ClienteRepository();
                clienteRepository.Insert(cliente);
                return StatusCode(201, new { mensage = $"Cliente {cliente.Nome} cadastrado com sucesso." });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensage = $"Falha: {e.Message}" });
            }
        }

        [HttpPut]
        public IActionResult Put(ClientePutModel model)
        {
            //edicao de funcionario
            try
            {
                Cliente cliente = new Cliente(model.IdCliente, model.Nome, model.Cpf, model.Telefone, model.Email, model.Profissao, model.DataNascimento, model.Logradouro, model.Numero, model.Bairro, model.Municipio, model.Estado, model.ComoConheceu, model.Observacao);
                ClienteRepository clienteRepository = new ClienteRepository();
                clienteRepository.Update(cliente);
                return StatusCode(200, new { mensage = $"Cliente {cliente.Nome} atualizado com sucesso." });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensage = $"Falha: {e.Message}" });
            }
        }

        [HttpDelete("{idCliente}")]
        public IActionResult Delete(Guid idCliente)
        {
            //exclusao de funcionario
            try
            {
                Cliente cliente = new Cliente();
                ClienteRepository clienteRepository = new ClienteRepository();
                cliente = clienteRepository.GetById(idCliente);
                if (cliente != null)
                {
                    clienteRepository.Delete(cliente.IdCliente);
                    return StatusCode(200, new { mensage = $"Cliente {cliente.Nome} excluido com sucesso." });
                }

                return StatusCode(204, new { mensage = $"Cliente não encontrado." });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensage = $"Falha: {e.Message}" });
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ClienteGetModel>))]
        public IActionResult GetAll()
        {
            try
            {
                List<ClienteGetModel> clienteGetModel = new List<ClienteGetModel>();
                ClienteRepository clienteRepository = new ClienteRepository();
                foreach (var item in clienteRepository.GetAll())
                {
                    ClienteGetModel model = new ClienteGetModel();
                    model.IdCliente = item.IdCliente;
                    model.Nome = item.Nome;
                    model.Cpf = item.Cpf;
                    model.Telefone = item.Telefone;
                    model.Email = item.Email;
                    model.Profissao = item.Profissao;
                    model.DataNascimento = item.DataNascimento;
                    model.Logradouro = item.Logradouro;
                    model.Numero = item.Numero;
                    model.Bairro = item.Bairro;
                    model.Municipio = item.Municipio;
                    model.Estado = item.Estado;
                    model.ComoConheceu = item.ComoConheceu;
                    model.Observacao = item.Observacao;
                    model.DataCadastro = item.DataCadastro;
                    model.DataAtualizacao = item.DataAtualizacao;
                    clienteGetModel.Add(model);
                }

                return StatusCode(200, clienteGetModel);
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensage = $"Falha: {e.Message}" });
            }
        }

        [HttpGet("{idCliente}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClienteGetModel))]
        public IActionResult GetById(Guid idCliente)
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteRepository clienteRepository = new ClienteRepository();
                cliente = clienteRepository.GetById(idCliente);
                if (cliente != null)
                {
                    ClienteGetModel model = new ClienteGetModel();
                    model.IdCliente = cliente.IdCliente;
                    model.Nome = cliente.Nome;
                    model.Cpf = cliente.Cpf;
                    model.Telefone = cliente.Telefone;
                    model.Email = cliente.Email;
                    model.Profissao = cliente.Profissao;
                    model.DataNascimento = cliente.DataNascimento;
                    model.Logradouro = cliente.Logradouro;
                    model.Numero = cliente.Numero;
                    model.Bairro = cliente.Bairro;
                    model.Municipio = cliente.Municipio;
                    model.Estado = cliente.Estado;
                    model.ComoConheceu = cliente.ComoConheceu;
                    model.Observacao = cliente.Observacao;
                    model.DataCadastro = cliente.DataCadastro;
                    model.DataAtualizacao = cliente.DataAtualizacao;
                    return StatusCode(200, model);
                }

                return StatusCode(204, new { mensage = $"Cliente não encontrado." });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { mensage = $"Falha: {e.Message}" });
            }
        }
    }
}
