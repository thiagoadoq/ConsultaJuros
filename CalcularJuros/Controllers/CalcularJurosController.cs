using System;
using System.Threading.Tasks;
using ConsultaJuros.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Controllers
{
    [ApiController]
    [Route("api/calJuros")]
    public class CalcularJurosController : Controller
    {
        private readonly IJurosRepository _repository;

        public CalcularJurosController(IJurosRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Calcular juros compostos
        /// </summary>
        /// <param name="vlInicial"> Valor a calcular</param>
        /// <param name="tempo">Quantidade de meses</param>
        /// <returns>Valor do juros compostos</returns>
        [Route("calculaJuros")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetJuros(decimal vlInicial, int tempo)
        {
            try
            {
                var vlJuro = await _repository.Get(vlInicial, tempo);               

                return Ok(new
                {
                    success = true,
                    content = vlJuro
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    success = false,
                    errors = new { message = ex }
                });
            }
        }

        /// <summary>
        /// Endpont para retorna o url do repositorio do projeto.     
        /// <returns>Url do GitHub </returns>
        [Route("showmethecode")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetRepository()
        {
            try
            {
                 var url = _repository.GetDiretorio();
                return Ok(new
                {
                    success = true,
                    content = url
                });               

            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    success = false,
                    errors = new { message = ex }
                });
            }
        }
    }
}
