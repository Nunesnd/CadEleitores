using CadEleitores.Data;
using CadEleitores.Models;

namespace CadEleitores.Repositorio
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly BancoContexto _bancoContexto;
        public EnderecoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public EnderecoModel Adicionar(EnderecoModel endereco)
        {
            _bancoContexto.Endereco.Add(endereco);
            _bancoContexto.SaveChanges();
            return endereco;
        }
    }
}
