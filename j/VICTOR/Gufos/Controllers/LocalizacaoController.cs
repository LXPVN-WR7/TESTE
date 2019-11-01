using System.Collections.Generic;
using System.Threading.Tasks;
using Gufos.Models;
using Gufos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizacaoController : ControllerBase
    {
        GufosContext context = new GufosContext();
        LocalizacaoRepositorio repositorio = new LocalizacaoRepositorio();

        [HttpGet]
        public async Task<ActionResult<List<Localizacao>>> Get()
        {
           
             List<Localizacao> listaDeLocalizacao = await repositorio.Get();   
            if(listaDeLocalizacao == null)
            {
                return NotFound();
            }
            return listaDeLocalizacao;

        }

       [HttpGet("{id}")]
       public async Task<ActionResult<Localizacao>> Get(int id)
       {
           Localizacao localizacaoRetornada = await context.Localizacao.FindAsync(id);
           if(localizacaoRetornada == null)
           {
               return NotFound();
           }
           return localizacaoRetornada;
       }



       [HttpPost]
       public async Task<ActionResult<Localizacao>> Post(Localizacao localizacao)
       {
           try
           {
            return await repositorio.Post(localizacao);
           }
           catch (System.Exception)
           {
               
               throw;
           }
       }
       
       [HttpPut("{id}")]
       public async Task<ActionResult<Localizacao>> Put(int id, Localizacao localizacao)
       {

         if(id != localizacao.LocalizacaoId)
         {
             return BadRequest();
         }
        
        try
        {
          await repositorio.Alterar(localizacao); 
        }
        catch(DbUpdateConcurrencyException)
        {
            var localizacaoValida = repositorio.Get(id);
            if (localizacaoValida == null)
            {
                return NotFound();
            }else{
                throw;
            }
        }
         return localizacao;
       }

       [HttpDelete("{id}")]
       public async Task<ActionResult<Localizacao>> Delete(int id)
       {
           Localizacao localizacaoRetornada = await repositorio.Get(id);
           if (localizacaoRetornada == null)
           {
               return NotFound();
           }
           await repositorio.Delete(localizacaoRetornada);
           return localizacaoRetornada;

       }


    }
}