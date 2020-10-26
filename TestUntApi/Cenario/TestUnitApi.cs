using CalculaJuros.Controllers;
using Xunit;

namespace TestUntApi
{
    public class TestUnitApi
    {
        [Fact]
        public async void GetConsultaJuros()
        {
            CalcularJurosController _controller = new CalcularJurosController();

            var resulte = await _controller.GetJuros(100,5);

            //Assert.Equal("Valor do juro=R$ 105,10","");
        }

        [Fact]
        public void GetRepositorioGitHub()
        {
            CalcularJurosController _controller = new CalcularJurosController();           

            Assert.Equal("https://github.com/thiagoadoq/TestConsultaJuros", _controller.GetRepository());
        }
    }
}
