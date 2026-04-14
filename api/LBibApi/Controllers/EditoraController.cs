using LBibApi.Models;
using LBibApi.Repositories.Interfaces;
using LBibApi.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LBibApi.Controllers
{
    [ApiController]
    [Route("api/v1/editora")]
    public class EditoraController : ControllerBase
    {
        private readonly IEditoraRepository _editoraRepository;

        public EditoraController(IEditoraRepository editoraRepository)
        {
            _editoraRepository = editoraRepository ?? throw new ArgumentNullException(nameof(editoraRepository));
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(EditoraViewModel editoraView)
        {
            Editora editora = new Editora(editoraView.Nome, editoraView.Endereco);
            _editoraRepository.Add(editora);

            return Ok();
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_editoraRepository.GetAll());
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Editora editora = _editoraRepository.GetById(id);
            if (editora == null)
                return NotFound();

            return Ok(editora);
        }
    }
}
