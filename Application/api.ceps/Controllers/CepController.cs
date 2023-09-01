using api.ceps.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.ceps.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepController : ControllerBase
    {
        private readonly ICepService _cepService;

        public CepController(ICepService cepService)
        {
            this._cepService = cepService;
        }

        [HttpGet]
        [Route("BuscarCep")]
        public async Task<IActionResult> BuscarCep(string cep)
        {
            var cepResult = await _cepService.BuscarCep(cep);
            return Ok(cepResult);
        }

        [HttpGet]
        [Route("ListarCidades")]
        public async Task<IActionResult> ListarCidades(string uf)
        {
            var cidadesResult = await _cepService.ListarCidades(uf);
            return Ok(cidadesResult);
        }

        [HttpGet]
        [Route("ListarUnidadesFederativas")]
        public async Task<IActionResult> ListarUnidadesFederativas()
        {
            var ufResult = await _cepService.ListarUnidadesFederativas();
            return Ok(ufResult);
        }

    }
}
