using System.Collections.Generic;
using System.Threading.Tasks;
using Gufos.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EventoController : ControllerBase
    {
        GufosContext context = new GufosContext();
        
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<Evento>>> Get()
        {
            var listaDeEventos = await context.Evento.Include(c => c.Categoria).Include(l => l.Localizacao).ToListAsync();


            if(listaDeEventos == null)
            {
                return NotFound();
            }

            foreach (var item in listaDeEventos)
            {
                item.Categoria.Evento = null;
                item.Localizacao.Evento = null;
            }
            return listaDeEventos;

        }
       [HttpGet("{id}")]
       public async Task<ActionResult<Evento>> Get(int id)
       {
           Evento eventoRetornada = await context.Evento.Include(c => c.Categoria).Include(l => l.Localizacao).FirstOrDefaultAsync(e => e.EventoId == id);
           if(eventoRetornada == null)
           {
               return NotFound();
           }
           return eventoRetornada;
       }

       [HttpPost]
       public async Task<ActionResult<Evento>> Post(Evento evento)
       {
           try
           {
             await context.Evento.AddAsync(evento);
             await context.SaveChangesAsync();
           }
           catch (System.Exception)
           {
               
               throw;
           }
           return evento;
       }
       
       [HttpPut("{id}")]
       public async Task<ActionResult<Evento>> Put(int id, Evento evento)
       {
         if(id != evento.EventoId)
         {
             return BadRequest();
         }
         context.Entry(evento).State = EntityState.Modified;
        try
        {
            await context.SaveChangesAsync();
        }
        catch(DbUpdateConcurrencyException)
        {
            var eventoValido = context.Evento.FindAsync(id);
            if (eventoValido == null)
            {
                return NotFound();
            }else{
                throw;
            }
        }
         return evento;
       }

       [HttpDelete("{id}")]
       public async Task<ActionResult<Evento>> Delete(int id)
       {
           Evento eventoRetornado = await context.Evento.FindAsync(id);
           if (eventoRetornado == null)
           {
               return NotFound();
           }
           context.Evento.Remove(eventoRetornado);
           await context.SaveChangesAsync();

           return eventoRetornado;

       }


    }
}