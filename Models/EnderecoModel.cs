using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadEleitores.Models
{
    public class EnderecoModel
    {
        [Column("EnderecoId")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("EnderecoLogradouro")]
        [Display(Name = "Logradouro")]
        public string? Logradouro { get; set; }

        [Column("EnderecoNumero")]
        [Display(Name = "Numero")]
        public string? Numero { get; set; }

        [Column("EnderecoComplemento")]
        [Display(Name = "Complemento")]
        public string? Complemento { get; set; }

        [Column("EnderecoBairro")]
        [Display(Name = "Bairro")]
        public string? Bairro { get; set; }

        [Column("EnderecoCidade")]
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        [Column("EnderecoUF")]
        [Display(Name = "UF")]
        public string? UF { get; set; }

        [Column("EnderecoCEP")]
        [Display(Name = "CEP")]
        public string? CEP { get; set; }
    }
}
