using System.Threading.Tasks;

namespace ConsultaJuros.Interface
{
    public interface IJurosRepository
    {
        Task<string> Get(decimal vlInicial, int tempo);
        string GetDiretorio();
    }
}
