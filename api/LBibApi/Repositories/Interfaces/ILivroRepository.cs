using LBibApi.Models;

namespace LBibApi.Repositories.Interfaces
{
    public interface ILivroRepository
    {
        void Add(Livro livro);
        List<Livro> GetAll();
        Livro GetById(int id);
    }
}
