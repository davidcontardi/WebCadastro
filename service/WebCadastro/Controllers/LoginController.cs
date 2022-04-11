using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebCadastro.Models;
using WebCadastro.Posts;

namespace WebCadastro.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _db;

        public LoginController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult FazerLogin(Login login)
        {
            var entrar = _db.Cadastro.FirstOrDefault(a => a.Email == login.Email && a.senha == login.senha);

            if(entrar == null)
            {
                return Unauthorized("Usuário não existe");
            }

            return Ok("Ok");
        }
    }
}
