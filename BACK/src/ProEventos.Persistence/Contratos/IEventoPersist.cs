using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist 
    {
         Task<Domain.Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
         Task<Domain.Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
         Task<Domain.Evento> GetAllEventosByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}