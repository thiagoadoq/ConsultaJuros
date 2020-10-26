using System;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

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
        public IActionResult GetTaxaJutos()
        {
            try
            {
                return Ok("0,01");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex });
            }           
        }
    }
}
