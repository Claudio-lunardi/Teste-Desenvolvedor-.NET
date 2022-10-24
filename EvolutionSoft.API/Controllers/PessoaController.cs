using EvolutionSoft.Models.Models;
using EvolutionSoft.Negocio.PessoaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace EvolutionSoft.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaNegocio _pessoaNegocio;

        public PessoaController(IPessoaNegocio pessoaNegocio)
        {
            _pessoaNegocio = pessoaNegocio;
        }
        [HttpGet]
        public async Task<List<Pessoa>> ObterListaPessoa()
        {
            return await _pessoaNegocio.ObterListaPessoa();
        }
        [HttpPost]
        public async Task IncluirPessoa([FromBody] Pessoa pessoa)
        {
            await _pessoaNegocio.IncluirPessoa(pessoa);
        }

        [HttpPut]
        public async Task EditarPessoa([FromBody] Pessoa pessoa)
        {
            await _pessoaNegocio.EditarPessoa(pessoa);
        }
        [HttpDelete]
        public async Task ExcluirPessoa([FromQuery]int Id)
        {
            await _pessoaNegocio.ExcluirPessoa(Id);
        }
    }
}
