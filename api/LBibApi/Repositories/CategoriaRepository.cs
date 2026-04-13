using LBibApi.Infra;
using LBibApi.Models;

namespace LBibApi.Repositories
{
    public class CategoriaRepository
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
            return Context.Categorias.Find(c => c.Id == id );
        }
    }
}
