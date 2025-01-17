using System.Collections.Generic;
using System.Threading.Tasks;
using GUFUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Controllers {

    [Route ("api/[controller]")]
   
    [ApiController]
   
    public class LocalizacaoController : ControllerBase {
   
        GufosContext context = new GufosContext ();

        [HttpGet]
   
        public async Task<ActionResult<List<Localizacao>>> Get () {
   
            List<Localizacao> listaDeLocalizacao = await context.Localizacao.ToListAsync ();
   
            if (listaDeLocalizacao == null) {
   
                return NotFound ();
   
            }
   
            return listaDeLocalizacao;
   
        }

        [HttpGet ("{id}")]
   
        public async Task<ActionResult<Localizacao>> Get (int id) {
   
            Localizacao LocalizacaoRetornada = await context.Localizacao.FindAsync (id);
   
            if (LocalizacaoRetornada == null) {
   
                return NotFound ();
   
            }
   
            return LocalizacaoRetornada;
   
        }

        [HttpPost]
   
        public async Task<ActionResult<Localizacao>> Post (Localizacao localizacao) {
   
            try {
   
                await context.Localizacao.AddAsync (localizacao);
   
                await context.SaveChangesAsync ();
   
            } catch (System.Exception) {

                throw;
            }
   
            return localizacao;
   
        }

        [HttpPut ("{id}")]
   
        public async Task<ActionResult<Localizacao>> Put (int id, Localizacao localizacao) {
   
            if(id != localizacao.LocalizacaoId)
            {
                return BadRequest();
            }
            context.Entry(localizacao).State = EntityState.Modified; // Alterações salvas localmente 
            
            try
            {
            await context.SaveChangesAsync(); // Aqui já salva no Banco de Dados
            }
            catch (DbUpdateConcurrencyException) 
            {   
                var localizacaoValida = context.Localizacao.FindAsync(id);
                if(localizacaoValida == null)
                {
                    return NotFound();
                }else{
                    throw;
                }
            }
            return localizacao;

            //return NoContent(); // (NoContent) Nenhum conteúdo a retornar
        }

        [HttpDelete ("{id}")]
        
        public async Task<ActionResult<Localizacao>> Delete (int id) {
        
            Localizacao localizacaoRetornada = await context.Localizacao.FindAsync (id);
        
            if (localizacaoRetornada == null) {
        
                return NotFound ();
        
            }

            context.Localizacao.Remove (localizacaoRetornada);
            
            await context.SaveChangesAsync ();

            return localizacaoRetornada;
        
        }
    }
}