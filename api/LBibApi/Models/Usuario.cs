using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBibApi.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("ddd")]
        public string DDDTelefone { get; set; }

        [Column("telefone")]
        public string? Telefone { get; set; }

        [Column("bairro")]
        public string? Bairro { get; set; }

        [Column("endereco")]
        public string? Endereco { get; set; }

        [Column("dt_cadastro")]
        public DateOnly DataCadastro { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; }

        public Usuario(string nome, string email, string dDDTelefone, string? telefone, string? bairro, string? endereco, DateOnly dataCadastro)
        {
            Nome = nome;
            Email = email;
            DDDTelefone = dDDTelefone;
            Telefone = telefone;
            Bairro = bairro;
            Endereco = endereco;
            DataCadastro = dataCadastro;
            Ativo = true;
        }
    }
}
