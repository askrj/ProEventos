using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
         Task<Domain.Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);
         Task<Domain.Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false);
         Task<Domain.Palestrante> GetAllPalestrantesByIdAsync(int palestranteId, bool includeEventos = false);

    }
}