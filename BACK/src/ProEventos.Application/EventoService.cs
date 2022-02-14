using System;
using System.Threading.Tasks;
using ProEventos.Application.Contratos;
using ProEventos.Domain;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Application
{
    public class EventoService : IEventoService
    {
        private readonly IGenericsPersist _genericsPersist;
        private readonly IEventoPersist _eventoPersist;

        public EventoService(IGenericsPersist genericsPersist, IEventoPersist eventoPersist)
        {
            _eventoPersist = eventoPersist;
            _genericsPersist = genericsPersist;

        }
        public async Task<Evento> AddEventos(Evento model)
        {
           try
           {
                _genericsPersist.Add<Evento>(model);
            if ( await _genericsPersist.SaveChangesAsync())
            {
                return await _eventoPersist.GetAllEventosByIdAsync(model.Id, false); 
            }
            return null;
           }
           catch (Exception ex)
           {
                throw new Exception(ex.Message);
           }

        }

        public async Task<Evento> UpDateEventos(int EventoId, Evento model)
        {
            try
            {
                var evento = await _eventoPersist.GetAllEventosByIdAsync(EventoId, false);
                if (evento == null) return null;

                model.Id = EventoId;
                 _genericsPersist.UpDate<Evento>(model);
            if ( await _genericsPersist.SaveChangesAsync())
            {
                return await _eventoPersist.GetAllEventosByIdAsync(model.Id, false); 
            }
            return null;
           }
           catch (Exception ex)
           {
                throw new Exception(ex.Message);
           }
        }

        public async Task<bool> DeleteEventos(int EventoId)
        {
            try
            {
                var evento = await _eventoPersist.GetAllEventosByIdAsync(EventoId, false);
                if (evento == null) throw new Exception("Evento para delete não encontrado.");

                 _genericsPersist.Delete<Evento>(evento);
                        
                return await _genericsPersist.SaveChangesAsync(); 
            
           }
           catch (Exception ex)
           {
                throw new Exception(ex.Message);
           }
        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoPersist.GetAllEventosAsync(includePalestrantes);
                if(eventos == null) return null; 

                return eventos;
            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message);
            }
        }

        public async Task<Evento> GetAllEventosByIdAsync(int EventoId, bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoPersist.GetAllEventosByIdAsync(EventoId, includePalestrantes);
                if(eventos == null) return null; 

                return eventos;
            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message);
            }
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoPersist.GetAllEventosByTemaAsync(tema, includePalestrantes);
                if(eventos == null) return null; 

                return eventos;
            }
            catch (Exception ex)
            {
                 throw new Exception(ex.Message);
            }
        }

    }
}