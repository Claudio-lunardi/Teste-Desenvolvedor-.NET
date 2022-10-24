using EvolutionSoft.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionSoft.Negocio.PessoaNegocio
{
    public interface IContatoNegocio
    {
        Task<List<Contato>> ObterListaContatos();

        Task IncluirContato(Contato contato);

        Task EditarContato(Contato contato);

        Task ExcluirContato(int id);
    }
}
