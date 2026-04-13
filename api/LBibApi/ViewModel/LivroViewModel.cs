using System.ComponentModel.DataAnnotations.Schema;

namespace LBibApi.ViewModel
{
    public class LivroViewModel
    {
        public string Titulo { get; set; }
        public string? ISBN { get; set; }
        public int Edicao { get; set; }
        public int AnoPublicacao { get; set; }
        public string? Sinopse { get; set; }
        public int QuantidadeTotal { get; set; }
        public int IdEditora { get; set; }
        public int IdAutor { get; set; }
    }
}
