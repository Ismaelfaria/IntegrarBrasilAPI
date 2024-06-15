using IntegrationAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegrationAPI.Controllers
{
    [Route("api/v1/CNPJ")]
    [ApiController]
    public class CnpjController : ControllerBase
    {
        public readonly ICnpjService _cnpjService;

        public CnpjController(ICnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        [HttpGet("busca/{cnpj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCnpj([FromRoute] string cnpj)
        {
            var response = await _cnpjService.BuscarCNPJ(cnpj);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
