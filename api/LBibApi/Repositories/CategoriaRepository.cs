using LBibApi.Infra;
using LBibApi.Models;
using LBibApi.Repositories.Interfaces;

namespace LBibApi.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ConnectionContext Context = new ConnectionContext();

        public void Add(Categoria categoria)
        {
            Context.Categorias.Add(categoria);
            Context.SaveChanges();
        }

        public List<Categoria> GetAll()
        {
            return Context.Categorias.ToList();
        }

        public Categoria GetById(int id)
        {
            return Context.Categorias.Find(id);
        }
    }
}
