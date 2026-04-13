using LBibApi.Infra;
using LBibApi.Models;
using LBibApi.Repositories.Interfaces;

namespace LBibApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ConnectionContext Context = new ConnectionContext();

        public void Add(Usuario usuario)
        {
            Context.Usuarios.Add(usuario);
            Context.SaveChanges();
        }

        public List<Usuario> GetAll()
        {
            return Context.Usuarios.ToList();
        }

        public Usuario GetById(int id)
        {
            return Context.Usuarios.Find(id);
        }
    }
}
