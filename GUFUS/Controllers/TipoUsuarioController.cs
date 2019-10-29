using System.Collections.Generic;
using System.Threading.Tasks;
using GUFUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Controllers {

    [Route ("api/[controller]")]
   
    [ApiController]
   
    public class TipoUsuarioController : ControllerBase {
   
        GufosContext context = new GufosContext ();

        [HttpGet]
   
        public async Task<ActionResult<List<TipoUsuario>>> Get () {
   
            List<TipoUsuario> listaTipoUsuario = await context.TipoUsuario.ToListAsync ();
   
            if (listaTipoUsuario == null) {
   
                return NotFound ();
   
            }
   
            return listaTipoUsuario;
   
        }

        [HttpGet ("{id}")]
   
        public async Task<ActionResult<TipoUsuario>> Get (int id) {
   
            TipoUsuario TipoUsuarioRetornado = await context.TipoUsuario.FindAsync (id);
   
            if (TipoUsuarioRetornado == null) {
   
                return NotFound ();
   
            }
   
            return TipoUsuarioRetornado;
   
        }

        [HttpPost]
   
        public async Task<ActionResult<TipoUsuario>> Post (TipoUsuario tipoUsuario) {
   
            try {
   
                await context.TipoUsuario.AddAsync (tipoUsuario);
   
                await context.SaveChangesAsync ();
   
            } catch (System.Exception) {

                throw;
            }
   
            return tipoUsuario;
   
        }

        [HttpPut ("{id}")]
   
        public async Task<ActionResult<TipoUsuario>> Put (int id, TipoUsuario tipoUsuario) {
   
            if(id != tipoUsuario.TipoUsuarioId)
            {
                return BadRequest();
            }
            context.Entry(tipoUsuario).State = EntityState.Modified; // Alterações salvas localmente 
            
            try
            {
            await context.SaveChangesAsync(); // Aqui já salva no Banco de Dados
            }
            catch (DbUpdateConcurrencyException) 
            {   
                var tipoUsuarioValido = context.Presenca.FindAsync(id);
                if(tipoUsuarioValido == null)
                {
                    return NotFound();
                }else{
                    throw;
                }
            }
            return tipoUsuario;

            //return NoContent(); // (NoContent) Nenhum conteúdo a retornar
        }

        [HttpDelete ("{id}")]
        
        public async Task<ActionResult<TipoUsuario>> Delete (int id) {
        
            TipoUsuario tipoUsuarioRetornado = await context.TipoUsuario.FindAsync (id);
        
            if (tipoUsuarioRetornado == null) {
        
                return NotFound ();
        
            }

            context.TipoUsuario.Remove (tipoUsuarioRetornado);
            
            await context.SaveChangesAsync ();

            return tipoUsuarioRetornado;
        
        }
    }
}