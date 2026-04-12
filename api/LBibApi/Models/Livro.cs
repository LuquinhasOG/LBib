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
        public string? Edicao { get; set; }

        [Column("ano_publicacao")]
        public string? ano_publicacao { get; set; }

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
    }
}
