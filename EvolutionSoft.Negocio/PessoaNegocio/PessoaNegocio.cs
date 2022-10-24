using EvolutionSoft.Infra.Entity;
using EvolutionSoft.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace EvolutionSoft.Negocio.PessoaNegocio
{
    public class PessoaNegocio : IPessoaNegocio
    {
        private readonly EntityContext _entityContext;

        public PessoaNegocio(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        public async Task IncluirPessoa(Pessoa pessoa)
        {
            await _entityContext.Pessoas.AddAsync(pessoa);
            await _entityContext.SaveChangesAsync();
        }

        public async Task<List<Pessoa>> ObterListaPessoa()
        {
            return await _entityContext.Pessoas.ToListAsync();
        }

        public async Task EditarPessoa(Pessoa pessoa)
        {
            _entityContext.Pessoas.Update(pessoa);
            await _entityContext.SaveChangesAsync();
        }

        public async Task ExcluirPessoa(int id)
        {
            var pessoaId = await _entityContext.Pessoas.SingleAsync(x => x.Id.Equals(id));
            _entityContext.Pessoas.Remove(pessoaId);
            await _entityContext.SaveChangesAsync();
        }
    }
}
