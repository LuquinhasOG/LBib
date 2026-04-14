using LBibApi.Infra;
using LBibApi.Models;
using LBibApi.Repositories.Interfaces;

namespace LBibApi.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly ConnectionContext Context = new ConnectionContext();

        public void Add(Funcionario funcionario)
        {
            Context.Funcionarios.Add(funcionario);
            Context.SaveChanges();
        }

        public List<Funcionario> GetAll()
        {
            return Context.Funcionarios.ToList();
        }

        public Funcionario GetById(int id)
        {
            return Context.Funcionarios.Find(id);
        }

        public Funcionario GetByUsuario(string usuario)
        {
            return Context.Funcionarios.SingleOrDefault(f => f.Usuario == usuario);
        }
    }
}
