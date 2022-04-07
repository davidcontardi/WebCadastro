using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Threading.Tasks;

namespace WebCadastro.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logar(string Email, string senha)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;database=cadastrologin; user=root; password=David41615323");
            await mySqlConnection.OpenAsync();

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = $"SELECT * FROM cadastro WHERE email = '{Email}' AND senha = '{senha}'";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            if(await reader.ReadAsync())
            {
                return Json(new { Msg = "Usuário cadastrado com sucesso!" });


            }
              
            return Json(new { }); 
        }
    }
}
