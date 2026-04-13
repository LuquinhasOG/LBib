using LBibApi.Models;
using LBibApi.Repositories.Interfaces;
using LBibApi.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LBibApi.Controllers
{
    [ApiController]
    [Route("api/v1/emprestimo")]
    public class EmprestimoController : ControllerBase
    {
        private readonly IEmprestimoRepository _emprestimoRepository;

        public EmprestimoController(IEmprestimoRepository emprestimoRepository)
        {
            _emprestimoRepository = emprestimoRepository;
        }

        [HttpPost]
        public IActionResult Add(EmprestimoViewModel emprestimoView)
        {
            var dataEmprestimo = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Unspecified);

            Emprestimo emprestimo = new Emprestimo(dataEmprestimo, emprestimoView.DataDevolucao, emprestimoView.Estado, emprestimoView.IdUsuario, emprestimoView.IdLivro);
            _emprestimoRepository.Add(emprestimo);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_emprestimoRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Emprestimo emprestimo = _emprestimoRepository.GetById(id);
            if (emprestimo == null)
                return NotFound();

            return Ok(emprestimo);
        }
    }
}
