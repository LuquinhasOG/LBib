using LBibApi.Models;
using LBibApi.Repositories.Interfaces;
using LBibApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LBibApi.Controllers
{
    [ApiController]
    [Route("api/v1/livro")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository ?? throw new ArgumentNullException(nameof(livroRepository));
        }

        [HttpPost]
        public IActionResult Add(LivroViewModel livroView)
        {
            Livro livro = new Livro(livroView.Titulo, livroView.ISBN, livroView.Edicao, livroView.AnoPublicacao, livroView.Sinopse, livroView.QuantidadeTotal, livroView.QuantidadeTotal, livroView.IdEditora, livroView.IdAutor);
            _livroRepository.Add(livro);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_livroRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Livro livro = _livroRepository.GetById(id);
            if (livro == null)
                return NotFound();

            return Ok(livro);
        }
    }
}
