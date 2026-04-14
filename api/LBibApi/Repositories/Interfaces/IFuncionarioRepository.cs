using LBibApi.Models;

namespace LBibApi.Repositories.Interfaces
{
    public interface IFuncionarioRepository
    {
        void Add(Funcionario funcionario);
        List<Funcionario> GetAll();
        Funcionario GetById(int id);
        Funcionario GetByUsuario(string usuario);
    }
}
