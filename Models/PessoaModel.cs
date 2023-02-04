using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadEleitores.Models
{
    public class PessoaModel
    {
        [Column("PessoaId")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PessoaNome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("PessoaPsudonimo")]
        [Display(Name = "Pseudonimo")]
        public string? Pseudonimo { get; set; }

        [Column("PessoaCpf")]
        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Column("PessoaNasc")]
        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        /*
         * [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
         */
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Nascimento { get; set; }

        [Column("PessoaFilhos")]
        [Display(Name = "Filhos")]
        public string? Filhos { get; set; }

        [Column("PessoaSexo")]
        [Display(Name = "Sexo")]
        public string? Sexo { get; set; }
    }

}
