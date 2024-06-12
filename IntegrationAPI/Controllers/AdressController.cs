using IntegrationAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegrationAPI.Controllers
{
    [Route("api/v1/adressController")]
    [ApiController]
    public class AdressController : ControllerBase
    {

        public readonly IAdressService _enderecoService;

        public AdressController(IAdressService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarEndereco([FromRoute] string cep)
        {
            var response = await _enderecoService.BuscarEndereco(cep);

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
