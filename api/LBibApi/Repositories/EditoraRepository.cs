using LBibApi.Infra;
using LBibApi.Models;
using LBibApi.Repositories.Interfaces;

namespace LBibApi.Repositories
{
    public class EditoraRepository : IEditoraRepository
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
            return Context.Editoras.Find(id);
        }
    }
}
