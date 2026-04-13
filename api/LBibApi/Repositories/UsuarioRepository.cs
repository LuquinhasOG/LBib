using LBibApi.Infra;
using LBibApi.Models;

namespace LBibApi.Repositories
{
    public class UsuarioRepository
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
            return Context.Usuarios.Find(u => u.Id == id);
        }
    }
}
