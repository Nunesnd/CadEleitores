using CadEleitores.Models;
using Microsoft.EntityFrameworkCore;

namespace CadEleitores.Data
{
    public class BancoContexto : DbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {

        }

        public DbSet<PessoaModel> Pessoa { get; set; }

        public DbSet<ProfissaoModel> Profissao { get; set; }
    }
}
