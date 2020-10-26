using CalculaJuros.Controllers;
using ConsultaJuros.Interface;
using ConsultaJuros.Model.Repository;
using Xunit;

namespace TestUntApi
{
    public class TestUnitApi
    {
        private IJurosRepository _repository = new JuroRepository();               

        [Fact]
        public async void GetConsultaJuros()
        {
            var vJuros = await _repository.Get(100, 5);

            Assert.Equal("R$ 105,10", vJuros);
        }

        [Fact]
        public void GetRepositorioGitHub()
        {
            var diretorio = _repository.GetDiretorio();

            Assert.Equal("https://github.com/thiagoadoq/ConsultaJuros", diretorio);
        }
    }
}
