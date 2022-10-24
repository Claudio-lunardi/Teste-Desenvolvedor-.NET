using EvolutionSoft.Models.Models;
using EvolutionSoft.Negocio.ContatoNegocio;
using Microsoft.AspNetCore.Mvc;

namespace EvolutionSoft.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoNegocio _IContatoNegocio;

        public ContatoController(IContatoNegocio iContatoNegocio)
        {
            _IContatoNegocio = iContatoNegocio;
        }

        [HttpGet]
        public async Task<List<Contato>> ObterListaPessoa()
        {
            return await _IContatoNegocio.ObterListaContatos();
        }
        [HttpPost]
        public async Task IncluirPessoa([FromBody] Contato Contato)
        {
            await _IContatoNegocio.IncluirContato(Contato);
        }

        [HttpPut]
        public async Task EditarPessoa([FromBody] Contato Contato)
        {
            await _IContatoNegocio.EditarContato(Contato);
        }
        [HttpDelete]
        public async Task ExcluirPessoa([FromQuery] int Id)
        {
            await _IContatoNegocio.ExcluirContato(Id);
        }




    }
}
