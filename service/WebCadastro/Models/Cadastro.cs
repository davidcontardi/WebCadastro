using System;

namespace WebCadastro.Models
{
    public class Cadastro
    {
        public long IdUsuario { get; set; }
        public string Email { get; set; }
        public string senha { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string datadeNascimento { get; set; }
        public int size { get; set; }
        public DateTime datadeCriacao { get; set; }
        public string contato { get; set; }

    }
}
