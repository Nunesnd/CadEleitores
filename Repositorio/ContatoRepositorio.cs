using CadEleitores.Data;
using CadEleitores.Models;

namespace CadEleitores.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public ContatoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }
        public PessoaModel Adicionar(PessoaModel pessoa)
        {
            //gravar no banco de dados
            _bancoContexto.Pessoa.Add(pessoa);
            _bancoContexto.SaveChanges();
            return pessoa;
        }

        public List<PessoaModel> BuscarTodos()
        {
            return _bancoContexto.Pessoa.ToList();
        }
    }
}
