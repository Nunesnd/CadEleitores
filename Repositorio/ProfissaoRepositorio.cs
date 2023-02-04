using CadEleitores.Data;
using CadEleitores.Models;

namespace CadEleitores.Repositorio
{
    public class ProfissaoRepositorio : IProfissaoRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public ProfissaoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public ProfissaoModel Adicionar(ProfissaoModel profissao)
        {
            _bancoContexto.Profissao.Add(profissao);
            _bancoContexto.SaveChanges();
            return profissao;
        }

        public List<ProfissaoModel> BuscarTodos()
        {
            return _bancoContexto.Profissao.ToList();
        }
        
    }
}