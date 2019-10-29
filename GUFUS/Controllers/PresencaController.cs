using System.Collections.Generic;
using System.Threading.Tasks;
using GUFUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Controllers {

    [Route ("api/[controller]")]
   
    [ApiController]
   
    public class PresencaController : ControllerBase {
   
        GufosContext context = new GufosContext ();

        [HttpGet]
   
        public async Task<ActionResult<List<Presenca>>> Get () {
   
            List<Presenca> listaDePresenca = await context.Presenca.ToListAsync ();
   
            if (listaDePresenca == null) {
   
                return NotFound ();
   
            }
   
            return listaDePresenca;
   
        }

        [HttpGet ("{id}")]
   
        public async Task<ActionResult<Presenca>> Get (int id) {
   
            Presenca PresencaRetornada = await context.Presenca.FindAsync (id);
   
            if (PresencaRetornada == null) {
   
                return NotFound ();
   
            }
   
            return PresencaRetornada;
   
        }

        [HttpPost]
   
        public async Task<ActionResult<Presenca>> Post (Presenca presenca) {
   
            try {
   
                await context.Presenca.AddAsync (presenca);
   
                await context.SaveChangesAsync ();
   
            } catch (System.Exception) {

                throw;
            }
   
            return presenca;
   
        }

        [HttpPut ("{id}")]
   
        public async Task<ActionResult<Presenca>> Put (int id, Presenca presenca) {
   
            if(id != presenca.PresencaId)
            {
                return BadRequest();
            }
            context.Entry(presenca).State = EntityState.Modified; // Alterações salvas localmente 
            
            try
            {
            await context.SaveChangesAsync(); // Aqui já salva no Banco de Dados
            }
            catch (DbUpdateConcurrencyException) 
            {   
                var presencaValida = context.Presenca.FindAsync(id);
                if(presencaValida == null)
                {
                    return NotFound();
                }else{
                    throw;
                }
            }
            return presenca;

            //return NoContent(); // (NoContent) Nenhum conteúdo a retornar
        }

        [HttpDelete ("{id}")]
        
        public async Task<ActionResult<Presenca>> Delete (int id) {
        
            Presenca presencaRetornada = await context.Presenca.FindAsync (id);
        
            if (presencaRetornada == null) {
        
                return NotFound ();
        
            }

            context.Presenca.Remove (presencaRetornada);
            
            await context.SaveChangesAsync ();

            return presencaRetornada;
        
        }
    }
}