using CalculaJuros.Service;
using ConsultaJuros.Interface;
using System;
using System.Threading.Tasks;

namespace ConsultaJuros.Model.Repository
{
    public class JuroRepository : IJurosRepository
    {
        public async Task<string> Get(decimal vlInicial, int tempo)
        {
            try
            {
                Api api = new Api();
                var vJuro = Convert.ToDouble(await api.GetJuros());

                var resultado = vlInicial * Convert.ToDecimal(Math.Pow(1 + vJuro, tempo));

                return String.Format("{0:C2}", resultado);                

            }
            catch (Exception ex)
            {
                throw;
            }
        }       

        public string GetDiretorio()
        {
            try 
            {
                return "https://github.com/thiagoadoq/ConsultaJuros";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
