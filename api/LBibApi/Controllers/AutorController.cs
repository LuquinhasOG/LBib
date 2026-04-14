using LBibApi.Models;
using LBibApi.Repositories.Interfaces;
using LBibApi.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LBibApi.Controllers
{
    [ApiController]
    [Route("api/v1/autor")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;

        public AutorController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository ?? throw new ArgumentNullException(nameof(autorRepository));
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(AutorViewModel autorView)
        {
            Autor autor = new Autor(autorView.Nome, autorView.Nacionalidade);
            _autorRepository.Add(autor);

            return Ok();
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Autor> autores = _autorRepository.GetAll();

            return Ok(autores);
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Autor autor = _autorRepository.GetById(id);
            if (autor == null)
                return NotFound();

            return Ok(autor);
        }
    }
}
