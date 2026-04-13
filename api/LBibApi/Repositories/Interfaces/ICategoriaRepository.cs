using LBibApi.Models;

namespace LBibApi.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        void Add(Categoria categoria);
        List<Categoria> GetAll();
        Categoria GetById(int id);
    }
}
