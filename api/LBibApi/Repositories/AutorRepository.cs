using LBibApi.Infra;
using LBibApi.Models;
using LBibApi.Repositories.Interfaces;

namespace LBibApi.Repositories
{
    public class AutorRepository : IAutorRepository
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

        public Autor GetById(int id)
        {
            return Context.Autores.Find(id);
        }
    }
}
