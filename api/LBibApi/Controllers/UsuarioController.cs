using LBibApi.Models;
using LBibApi.Repositories.Interfaces;
using LBibApi.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LBibApi.Controllers
{
    [ApiController]
    [Route("api/v1/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(UsuarioViewModel usuarioView)
        {
            Usuario usuario = new Usuario(usuarioView.Nome, usuarioView.Email, usuarioView.DDDTelefone, usuarioView.Telefone, usuarioView.Bairro, usuarioView.Endereco, DateOnly.FromDateTime(DateTime.Now));
            _usuarioRepository.Add(usuario);

            return Ok();
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_usuarioRepository.GetAll()); 
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Usuario usuario = _usuarioRepository.GetById(id);
            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }
    }
}
