using LBibApi.Models;
using LBibApi.Repositories.Interfaces;
using LBibApi.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LBibApi.Controllers
{
    [ApiController]
    [Route("api/v1/funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(FuncionarioViewModel funcionarioView)
        {
            Funcionario funcionario = new Funcionario(funcionarioView.Nome, funcionarioView.Usuario, funcionarioView.Senha, true, funcionarioView.Permissao);
            _funcionarioRepository.Add(funcionario);

            return Ok();
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_funcionarioRepository.GetAll()); 
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Funcionario funcionario = _funcionarioRepository.GetById(id);
            if (funcionario == null)
                return NotFound();

            return Ok(funcionario);
        }
    }
}
