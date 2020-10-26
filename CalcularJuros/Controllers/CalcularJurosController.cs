using System;
using System.Threading.Tasks;
using CalculaJuros.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Controllers
{
    [ApiController]
    [Route("api/calJuros")]
    public class CalcularJurosController : Controller
    {
        /// <summary>
        /// Endpont para calcular juros compostos
        /// </summary>
        /// <param name="vlInicial">Valor contabel</param>
        /// <param name="tempo">Quantidade de messes</param>
        /// <returns>Valor do juro</returns>
        [Route("calculaJuros")]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetJuros(decimal vlInicial, int tempo)
        {
            Api api = new Api();
            var vJuro = Convert.ToDouble(await api.GetJuros());

            try
            {
                var resultado = vlInicial * Convert.ToDecimal(Math.Pow(1 + vJuro, tempo));
                var valorJuro = String.Format("{0:C2}", resultado);

                return Ok(new
                {
                    success = true,
                    content = valorJuro
                });

            }
            catch (Exception ex)
            {
                return BadRequest(new {

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
        public string GetRepository()
        {
            try
            {
                return "https://github.com/thiagoadoq/TestConsultaJuros";

            }
            catch (Exception)
            {
                return "Não foi possivel localizar o diretório  do github";
            }
        }
    }
}
