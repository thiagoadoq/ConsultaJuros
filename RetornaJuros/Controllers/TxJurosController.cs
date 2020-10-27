using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RetornaJuros.Controllers
{
    [ApiController]
    [Route("api/txJuros")]
    public class TxJurosController : Controller
    {
        /// <summary>
        /// Endpont para retornar o juro
        /// </summary>
        /// <returns>Juros</returns>
        [Route("taxaJuros")]
        [HttpGet]       
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public string GetTaxaJutos()
        {
            try
            {
                return "0,01";
            }
            catch (Exception ex)
            {
                return $"Não foi possivel retornar a taxa de juros={ex}";
            }           
        }
    }
}
