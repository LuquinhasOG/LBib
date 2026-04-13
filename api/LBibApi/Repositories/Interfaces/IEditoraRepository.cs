using LBibApi.Models;

namespace LBibApi.Repositories.Interfaces
{
    public interface IEditoraRepository
    {
        void Add(Editora editora);
        List<Editora> GetAll();
        Editora GetById(int id);
    }
}
