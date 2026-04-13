using LBibApi.Infra;
using LBibApi.Models;
using LBibApi.Repositories.Interfaces;

namespace LBibApi.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly ConnectionContext Context = new ConnectionContext();

        public void Add(Emprestimo categoria)
        {
            Context.Emprestimos.Add(categoria);
            Context.SaveChanges();
        }

        public List<Emprestimo> GetAll()
        {
            return Context.Emprestimos.ToList();
        }

        public Emprestimo GetById(int id)
        {
            return Context.Emprestimos.Find(id);
        }
    }
}
