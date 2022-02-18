using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
         Task<Evento> AddEventos(Evento Model);
         Task<Evento> UpDateEventos(int EventoId, Evento Model);
         Task<bool> DeleteEventos(int EventoId);

         Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
         Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
         Task<Evento> GetAllEventosByIdAsync(int EventoId, bool includePalestrantes = false);
    }
}