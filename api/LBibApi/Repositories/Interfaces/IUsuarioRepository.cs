using LBibApi.Models;

namespace LBibApi.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);
        List<Usuario> GetAll();
        Usuario GetById(int id);
    }
}
