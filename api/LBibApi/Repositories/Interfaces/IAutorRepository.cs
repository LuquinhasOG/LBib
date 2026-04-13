using LBibApi.Models;

namespace LBibApi.Repositories.Interfaces
{
    public interface IAutorRepository
    {
        void Add(Autor autor);
        List<Autor> GetAll();
        Autor GetById(int id);
    }
}
