using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebCadastro.DTOs;
using WebCadastro.Models;

namespace WebCadastro.Controllers
{
    [Route("api/cadastro")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CadastroController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult CriarCadastro(Cadastro cadastro)
        {
            var usuarioComMesmoEmail = _db.Cadastro
                .Where(u => u.Email == cadastro.Email);

            var qtdeUsuarioComMesmoEmail = usuarioComMesmoEmail.Count();
            var tenhoUsuarioComMesmoEmail = qtdeUsuarioComMesmoEmail > 0;

            if (tenhoUsuarioComMesmoEmail)
                throw new Exception("Já existe usuário com esse email");

            var novoCadastro = new Cadastro
            {
                Email            = cadastro.Email,
                senha            = cadastro.senha,
                Nome             = cadastro.Nome,
                CPF              = cadastro.CPF,
                datadeNascimento = cadastro.datadeNascimento,
                size             = cadastro.size,
                datadeCriacao    = cadastro.datadeCriacao,
                contato          = cadastro.contato,

            };

            _db.Cadastro.Add(novoCadastro);
            _db.SaveChanges();

            var dto = new CadastroDto(novoCadastro);

            return Ok(dto);
        }
    }
}
