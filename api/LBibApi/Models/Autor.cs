using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBibApi.Models
{
    [Table("autor")]
    public class Autor
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("nacionalidade")]
        public string Nacionalidade { get; set; }

        public Autor(string nome, string nacionalidade)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
        }
    }
}
