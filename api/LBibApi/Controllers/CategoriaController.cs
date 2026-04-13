using LBibApi.Models;
using LBibApi.Repositories.Interfaces;
using LBibApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LBibApi.Controllers
{
    [ApiController]
    [Route("api/v1/categoria")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository ?? throw new ArgumentNullException(nameof(categoriaRepository));
        }

        [HttpPost]
        public IActionResult Add(CategoriaViewModel categoriaView)
        {
            Categoria categoria = new Categoria(categoriaView.Nome);
            _categoriaRepository.Add(categoria);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoriaRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Categoria categoria = _categoriaRepository.GetById(id);
            if (categoria == null)
                return NotFound();

            return Ok(categoria);
        }
    }
}
