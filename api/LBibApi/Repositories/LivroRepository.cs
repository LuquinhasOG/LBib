using LBibApi.Infra;
using LBibApi.Models;
using LBibApi.Repositories.Interfaces;

namespace LBibApi.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ConnectionContext Context = new ConnectionContext();

        public void Add(Livro livro)
        {
            Context.Livros.Add(livro);
            Context.SaveChanges();
        }

        public List<Livro> GetAll()
        {
            return Context.Livros.ToList();
        }

        public Livro GetById(int id)
        {
            return Context.Livros.Find(id);
        }
    }
}
