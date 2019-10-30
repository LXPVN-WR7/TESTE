using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TW.Models;

namespace TW.Controllers {
    [Route ("api/[controller]")]

    [ApiController]

    [Produces ("application/json")]
    public class ClassificadoController : ControllerBase {

        TwContext context = new TwContext ();

        [HttpGet]

        public async Task<ActionResult<List<Classificado>>> Get () {
            try {
                return await context.Classificado.ToListAsync ();
            } catch (System.Exception) {

                throw;
            }
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Classificado>> Get (int id) {
            
            Classificado classificado = await context.Classificado.FindAsync (id);

            if(classificado == null){
                return NotFound ();
            }
            return classificado;
        }

        [HttpPost]

        public async Task<ActionResult<Classificado>> Post (Classificado classificado) {

            try {
                await context.Classificado.AddAsync (classificado);
                await context.SaveChangesAsync ();
            } catch (System.Exception) {

                throw;
            }
            return classificado;
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Classificado>> Put (int id, Classificado classificado) {
            if(id != classificado.IdClassificado){
                return BadRequest();
            }
            try
            {
                context.Entry(classificado).State = EntityState.Modified;
                await context.SaveChangesAsync();   
                return classificado;

            }
            catch (DbUpdateConcurrencyException)
            {
                var classificadoValido = await context.Classificado.FindAsync(id);
                if(classificadoValido == null){
                    return NotFound();
                }else{
                    throw;
                }
                throw;
            }
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Classificado>> Delete (int id) {

            Classificado classificado = await context.Classificado.FindAsync(id);

            if(classificado == null){
                return NotFound();
            }

            context.Classificado.Remove (classificado);

            await context.SaveChangesAsync();

            return classificado;

        }
    }
}