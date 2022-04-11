using WebCadastro.Models;

namespace WebCadastro.DTOs
{
    public class CadastroDto
    {
        public long   IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public CadastroDto() { }

        public CadastroDto(Cadastro cadastro)
        {
            IdUsuario = cadastro.IdUsuario;
            Nome = cadastro.Nome;
            Email = cadastro.Email;
        }
    }
}
