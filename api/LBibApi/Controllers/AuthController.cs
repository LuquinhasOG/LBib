using LBibApi.Models;
using LBibApi.Repositories.Interfaces;
using LBibApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace LBibApi.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public AuthController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            Funcionario funcionario = _funcionarioRepository.GetByUsuario(username);
            if (funcionario == null || !funcionario.Ativo)
                return BadRequest("Usuario ou senha invalidos");

            if (funcionario.Senha == password)
            {
                var token = TokenService.GenerateToken(new Models.Funcionario());
                return Ok(token);
            }

            return BadRequest("Usuario ou senha invalidos");
        }
    }
}
