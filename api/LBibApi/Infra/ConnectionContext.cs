using LBibApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LBibApi.Infra
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Server=localhost;" +
                "Database=lbib;" +
                "Port=5432;" +
                "User Id=postgres;" +
                "Password=dbadmin;"
            );
        }
    }
}
