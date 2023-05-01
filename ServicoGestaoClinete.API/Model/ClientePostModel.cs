using System.ComponentModel.DataAnnotations;

namespace ServicoGestaoClinete.API.Model
{
    public class ClientePostModel
    {
        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        public string Nome { get; set; }

        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Por favor, informe 11 digitos numéricos")]
        [Required(ErrorMessage = "Por favor, informe CPF do cliente.")]
        public string Cpf { get; set; }

        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Por favor, informe no mínimo 11 digitos numéricos")]
        [Required(ErrorMessage = "Por favor, informe o telefone do cliente.")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de e-mail valido.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe e-mail vlido.")]
        public string Email { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a profissão do cliente.")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "Por favor, informe a sua data de nascimento.")]
        public DateTime DataNascimento { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o logradouro do cliente.")]
        public string Logradouro { get; set; }

        [Range(1, 99999999, ErrorMessage = "Por favor, informe o numero da casa do cliente entre 1 a 999999999.")]
        public int Numero { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(80, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o bairro do cliente.")]
        public string Bairro { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(80, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o município do cliente.")]
        public string Municipio { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(3, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o estado do cliente.")]
        public string Estado { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {5} caracteres.")]
        [MaxLength(200, ErrorMessage = "Por favor, informe no máximo {500} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe como nos conheceu.")]
        public string ComoConheceu { get; set; }

        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {5} caracteres.")]
        [MaxLength(200, ErrorMessage = "Por favor, informe no máximo {500} caracteres.")]
        [Required(ErrorMessage = "Por favor, escreve uma observação ou um comentario sobre você.")]
        public string Observacao { get; set; }
    }
}
