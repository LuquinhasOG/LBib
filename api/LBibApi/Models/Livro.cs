using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBibApi.Models
{
    [Table("livro")]
    public class Livro
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("isbn")]
        public string? ISBN { get; set; }

        [Column("edicao")]
        public int Edicao { get; set; }

        [Column("ano_publicacao")]
        public int AnoPublicacao { get; set; }

        [Column("sinopse")]
        public string? Sinopse { get; set; }

        [Column("qt_total")]
        public int QuantidadeTotal { get; set; }

        [Column("qt_disponivel")]
        public int QuantidadeDisponivel { get; set; }

        [Column("editora_id")]
        public int IdEditora { get; set; }

        [Column("autor_id")]
        public int IdAutor{ get; set; }

        public Livro(string titulo, string? iSBN, int edicao, int anoPublicacao, string? sinopse, int quantidadeTotal, int quantidadeDisponivel, int idEditora, int idAutor)
        {
            Titulo = titulo;
            ISBN = iSBN;
            Edicao = edicao;
            AnoPublicacao = anoPublicacao;
            Sinopse = sinopse;
            QuantidadeTotal = quantidadeTotal;
            QuantidadeDisponivel = quantidadeDisponivel;
            IdEditora = idEditora;
            IdAutor = idAutor;
        }
    }
}
