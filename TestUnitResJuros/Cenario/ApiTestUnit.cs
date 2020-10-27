using RetornaJuros.Controllers;
using Xunit;

namespace TestUnitResJuros.Cenario
{
    public class ApiTestUnit
    {
        [Fact]
        public void GetConsultaJuros()
        {
            TxJurosController _controller = new TxJurosController();

            var vtaxa =  _controller.GetTaxaJutos();

            Assert.Equal("0,01", vtaxa);
        }
    }
}
