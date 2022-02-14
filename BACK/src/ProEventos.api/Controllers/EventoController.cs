using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;
using ProEventos.Persistence.Contexto;
using ProEventos.Application.Contratos;
using Microsoft.AspNetCore.Http;

namespace ProEventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        private readonly IEventoService _eventoService;

        public EventoController(IEventoService eventoService)
        {
            _eventoService = eventoService;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                 var eventos = await _eventoService.GetAllEventosAsync(true);
                 if(eventos == null) return NotFound("Nenhum evento encontrado.");
                 return Ok(eventos);
            }
            catch (System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError,
                 $"Erro ao tentar recuperar evento. Error: {ex.Message}");
            }
           
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                 var eventos = await _eventoService.GetAllEventosByIdAsync(id, true);
                 if(eventos == null) return NotFound("Nenhum evento encontrado.");
                 return Ok(eventos);
            }
            catch (System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError,
                 $"Erro ao tentar recuperar evento. Error: {ex.Message}");
            }
        }

        [HttpGet("{tema}/tema")]
        public async Task<IActionResult> GetTema(string tema)
        {
            try
            {
                 var eventos = await _eventoService.GetAllEventosByTemaAsync(tema, true);
                 if(eventos == null) return NotFound("Nenhum evento encontrado.");
                 return Ok(eventos);
            }
            catch (System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError,
                 $"Erro ao tentar recuperar evento. Error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Evento model){
            try
            {
                 var eventos = await _eventoService.AddEventos(model);
                 if(eventos == null) return BadRequest("Erro ao adicionar evento.");
                 return Ok(eventos);
            }
            catch (System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError,
                 $"Erro ao tentar adicionar evento. Error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Evento model){
            try
            {
                 var eventos = await _eventoService.UpDateEventos(id, model);
                 if(eventos == null) return BadRequest("Erro ao atualizar evento.");
                 return Ok(eventos);
            }
            catch (System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError,
                 $"Erro ao tentar atualizar evento. Error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, Evento model){
            try
            {
                 return await _eventoService.DeleteEventos(id) ?
                 Ok("Deletado") :
                 BadRequest("Evento não deletado");
            }
            catch (System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError,
                 $"Erro ao tentar deletar evento. Error: {ex.Message}");
            }
        }
    }
}
