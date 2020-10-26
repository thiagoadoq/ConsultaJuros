using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculaJuros.Service
{
    public class Api
    {
        public async Task<decimal> GetJuros()
        {
            try
            {
                string url = "http://localhost:5000/api/txJuros/taxaJuros";
                HttpClient client = new HttpClient();
                var response = Convert.ToDecimal(await client.GetStringAsync(url));

                return response;
            }
            catch (Exception)
            {

                throw;
            }         
        }
    }
}
