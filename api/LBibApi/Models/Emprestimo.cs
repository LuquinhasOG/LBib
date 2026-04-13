using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBibApi.Models
{
    [Table("emprestimo")]
    public class Emprestimo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("dt_emprestimo")]
        public DateTime DataEmprestimo { get; set; }

        [Column("dt_devolucao")]
        public DateOnly DataDevolucao { get; set; }

        [Column("dt_devolvido")]
        public DateTime DataDevolvido { get; set; }

        [Column("estado")]
        public string Estado { get; set; }

        [Column("usuario_id")]
        public int IdUsuario { get; set; }

        [Column("livro_id")]
        public int IdLivro { get; set; }

        public Emprestimo(DateTime dataEmprestimo, DateOnly dataDevolucao, string estado, int idUsuario, int idLivro)
        {
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
            Estado = estado;
            IdUsuario = idUsuario;
            IdLivro = idLivro;
        }
    }
}
