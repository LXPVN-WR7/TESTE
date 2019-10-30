using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TW.Models;
using TW.Repositorios;

namespace TW.Controllers {
    [Route ("api/[controller]")]

    [ApiController]

    [Produces ("application/json")]
    public class ClassificadoController : ControllerBase {

        ClassificadoRepositorio repositorio = new ClassificadoRepositorio();

        [HttpGet]

        public async Task<ActionResult<List<Classificado>>> Get () {
            try {
                return await repositorio.Get ();
            } catch (System.Exception) {

                throw;
            }
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Classificado>> Get (int id) {
            
            Classificado classificadoRetornado = await repositorio.Get (id);

            if(classificadoRetornado == null){
                return NotFound ();
            }
            return classificadoRetornado;
        }

        [HttpPost]

        public async Task<ActionResult<Classificado>> Post (Classificado classificado) {

            try {
                
                await repositorio.Post(classificado);

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
                
                return await repositorio.Put(classificado);

            }
            catch (DbUpdateConcurrencyException)
            {
                var classificadoValido = await repositorio.Get(id);
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

            Classificado classificadoRetornado = await repositorio.Get(id);

            if(classificadoRetornado == null){
                
                return NotFound();

            }

            await repositorio.Delete(classificadoRetornado);
           
            return classificadoRetornado;

        }
    }
}