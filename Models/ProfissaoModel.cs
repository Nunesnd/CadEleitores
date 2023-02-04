using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadEleitores.Models
{
    public class ProfissaoModel

    {
        [Column("ProfissaoId")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("ProfissaoNome")]
        [Display(Name = "Nome")]
        public string? NomeProfissao { get; set; }
    }
}
