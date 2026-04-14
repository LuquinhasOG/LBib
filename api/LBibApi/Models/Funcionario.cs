using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LBibApi.Models
{
    [Table("funcionario")]
    public class Funcionario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("usuario")]
        public string Usuario { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("ativo")]
        public bool Ativo { get; set; }

        [Column("permissao")]
        public int Permissao { get; set; }

        public Funcionario() {}

        public Funcionario(string nome, string usuario, string senha, bool ativo, int permissao)
        {
            Nome = nome;
            Usuario = usuario;
            Senha = senha;
            Ativo = ativo;
            Permissao = permissao;
        }
    }
}
