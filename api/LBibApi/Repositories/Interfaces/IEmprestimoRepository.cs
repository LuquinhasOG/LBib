using LBibApi.Models;

namespace LBibApi.Repositories.Interfaces
{
    public interface IEmprestimoRepository
    {
        void Add(Emprestimo emprestimo);
        List<Emprestimo> GetAll();
        Emprestimo GetById(int id);
    }
}
