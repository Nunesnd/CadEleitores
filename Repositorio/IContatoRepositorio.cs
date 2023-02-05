using CadEleitores.Models;

namespace CadEleitores.Repositorio
{
    public interface IContatoRepositorio
    {
        List<PessoaModel> BuscarTodos();
        PessoaModel Adicionar(PessoaModel pessoa);



    }
}
