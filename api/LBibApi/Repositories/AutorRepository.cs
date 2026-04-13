using LBibApi.Infra;
using LBibApi.Models;

namespace LBibApi.Repositories
{
    public class AutorRepository
    {
        private readonly ConnectionContext Context = new ConnectionContext();

        public void Add(Autor autor)
        {
            Context.Autores.Add(autor);
            Context.SaveChanges();
        }

        public List<Autor> GetAll()
        {
            return Context.Autores.ToList();
        }

        public Categoria GetById(int id)
        {
            return Context.Autores.Find(a => a.Id == id);
        }
    }
}
