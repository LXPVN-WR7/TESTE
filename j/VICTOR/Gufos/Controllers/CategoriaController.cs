using System;
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
    public class CategoriaController : ControllerBase
    {
     
        GufosContext context = new GufosContext();
        CategoriaRepositorio repositorio = new CategoriaRepositorio();

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Get()
        {
            try{

                return await repositorio.Get();

            }catch(System.Exception)
            {
                throw;
            }            
        }

  

        [HttpGet("{id}")]
       public async Task<ActionResult<Categoria>> Get(int id)
       {
           Categoria categoriaRetornada = await repositorio.Get(id);
           if(categoriaRetornada == null)
           {
               return NotFound();
           }
           return categoriaRetornada;
       }

       [HttpPost]
       public async Task<ActionResult<Categoria>> Post(Categoria categoria)
       {
           try
           {
               return await repositorio.Post(categoria);
           }
           catch (System.Exception)
           {
               
               throw;
           }
       }
       
       [HttpPut("{id}")]
       public async Task<ActionResult> Put(int id, Categoria categoria)
       {
           Categoria categoriaRetornada = await context.Categoria.FindAsync(id);
          if(categoriaRetornada == null)
          {
              return NotFound();
          }
          categoriaRetornada.Titulo = categoria.Titulo;
          context.Categoria.Update(categoriaRetornada);
          await context.SaveChangesAsync();

          return NoContent();

       }
       [HttpDelete("{id}")]
       public async Task<ActionResult<Categoria>> Delete(int id)
       {
           Categoria categoriaRetornada = await context.Categoria.FindAsync(id);
           if (categoriaRetornada == null)
           {
               return NotFound();
           }
           context.Categoria.Remove(categoriaRetornada);
           await context.SaveChangesAsync();

           return categoriaRetornada;

       }


    }
}