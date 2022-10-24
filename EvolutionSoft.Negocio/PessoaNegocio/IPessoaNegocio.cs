using EvolutionSoft.Models.Models;

namespace EvolutionSoft.Negocio.PessoaNegocio
{
    public interface IPessoaNegocio
    {
        Task<List<Pessoa>> ObterListaPessoa();

        Task IncluirPessoa(Pessoa pessoa);

        Task EditarPessoa(Pessoa pessoa);

        Task ExcluirPessoa(int id);
    }
}
