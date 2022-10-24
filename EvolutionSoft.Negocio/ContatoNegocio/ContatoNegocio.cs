using EvolutionSoft.Infra.Entity;
using EvolutionSoft.Models.Models;
using EvolutionSoft.Negocio.PessoaNegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionSoft.Negocio.ContatoNegocio
{
    public class ContatoNegocio : IContatoNegocio
    {
        private readonly EntityContext _entityContext;

        public ContatoNegocio(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        public async Task EditarContato(Contato contato)
        {
            _entityContext.Contatos.Update(contato);
            await _entityContext.SaveChangesAsync();
        }

        public async Task ExcluirContato(int id)
        {
            var ContatoId = await _entityContext.Contatos.SingleAsync(x => x.Id.Equals(id));
            _entityContext.Contatos.Remove(ContatoId);
            await _entityContext.SaveChangesAsync();
        }

        public async Task IncluirContato(Contato contato)
        {
            await _entityContext.Contatos.AddAsync(contato);
            await _entityContext.SaveChangesAsync();
        }

        public async Task<List<Contato>> ObterListaContatos()
        {
            return await _entityContext.Contatos.ToListAsync();

        }
    }
}
