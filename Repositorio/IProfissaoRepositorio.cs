using CadEleitores.Models;

namespace CadEleitores.Repositorio
{
    public interface IProfissaoRepositorio
    {
        List<ProfissaoModel> BuscarTodos();
        ProfissaoModel Adicionar(ProfissaoModel profissao);
    }
}
