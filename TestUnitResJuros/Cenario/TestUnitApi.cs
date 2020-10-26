using RetornaJuros.Controllers;
using Xunit;

namespace TestUnitResJuros
{
    public class TestUnitApi
    {
        [Fact]
        public void RetornarTaxaJuros()
        {
            TxJurosController _controller = new TxJurosController();

            //Assert.Equal("0,01", _controller.GetTaxaJutos());

        }
    }
}
