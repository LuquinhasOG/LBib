using LBibApi.Infra;
using LBibApi.Models;

namespace LBibApi.Repositories
{
    public class EditoraRepository
    {
        private readonly ConnectionContext Context = new ConnectionContext();

        public void Add(Editora editora)
        {
            Context.Editoras.Add(editora);
            Context.SaveChanges();
        }

        public List<Editora > GetAll()
        {
            return Context.Editoras.ToList();
        }

        public Editora GetById(int id)
        {
            return Context.Editoras.Find(e => e.Id == id);
        }
    }
}
