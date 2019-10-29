using System.Collections.Generic;
using System.Threading.Tasks;
using GUFUS.Models;
using GUFUS.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Controllers {

    [Route ("api/[controller]")]

    [ApiController]

    public class CategoriaController : ControllerBase {
        GufosContext context = new GufosContext ();
        CategoriaRepositorio repositorio = new CategoriaRepositorio ();

        [HttpGet]

        public async Task<ActionResult<List<Categoria>>> Get () {

            try {

                return await repositorio.Get ();

            } catch (System.Exception) {

                throw;

            }
        }

        [HttpGet ("{id}")]

        public async Task<ActionResult<Categoria>> Get (int id) {

            Categoria categoriaRetornada = await repositorio.Get (id);

            if (categoriaRetornada == null) {
                return NotFound ();
            }
            return categoriaRetornada;
        }

        [HttpPost]

        public async Task<ActionResult<Categoria>> Post (Categoria categoria) {

            try {
                await context.Categoria.AddAsync (categoria);
                await context.SaveChangesAsync ();
            } catch (System.Exception) {

                throw;
            }
            return categoria;

        }

        [HttpPut ("{id}")]

        public async Task<ActionResult> Put (int id, Categoria categoria) {

            if (id != categoria.CategoriaId) {
                return BadRequest ();
            }

            try {
                await repositorio.Alterar (categoria);
            } catch (DbUpdateConcurrencyException) {
                var localizacaoValida = repositorio.Get (id);
                if (localizacaoValida == null) {
                    return NotFound ();
                } else {
                    throw;
                }
            }
            return localizacao;
        }

        [HttpDelete ("{id}")]

        public async Task<ActionResult<Categoria>> Delete (int id) {

            Categoria categoriaRetornada = await context.Categoria.FindAsync (id);

            if (categoriaRetornada == null) {
                
                return NotFound ();

            }

            context.Categoria.Remove (categoriaRetornada);

            await context.SaveChangesAsync ();

            return categoriaRetornada;

        }
    }
}