using System.Collections.Generic;
using System.Threading.Tasks;
using GUFUS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Controllers {

    [Route ("api/[controller]")]
   
    [ApiController]
   
    public class UsuarioController : ControllerBase {
   
        GufosContext context = new GufosContext ();

        [HttpGet]
   
        public async Task<ActionResult<List<Usuario>>> Get () {
   
            List<Usuario> listaDeUsuario = await context.Usuario.ToListAsync ();
   
            if (listaDeUsuario == null) {
   
                return NotFound ();
   
            }
   
            return listaDeUsuario;
   
        }

        [HttpGet ("{id}")]
   
        public async Task<ActionResult<Usuario>> Get (int id) {
   
            Usuario UsuarioRetornado = await context.Usuario.FindAsync (id);
   
            if (UsuarioRetornado == null) {
   
                return NotFound ();
   
            }
   
            return UsuarioRetornado;
   
        }

        [HttpPost]
   
        public async Task<ActionResult<Usuario>> Post (Usuario usuario) {
   
            try {
   
                await context.Usuario.AddAsync (usuario);
   
                await context.SaveChangesAsync ();
   
            } catch (System.Exception) {

                throw;
            }
   
            return usuario;
   
        }

        [HttpPut ("{id}")]
   
        public async Task<ActionResult<Usuario>> Put (int id, Usuario usuario) {
   
            if(id != usuario.UsuarioId)
            {
                return BadRequest();
            }
            context.Entry(usuario).State = EntityState.Modified; // Alterações salvas localmente 
            
            try
            {
            await context.SaveChangesAsync(); // Aqui já salva no Banco de Dados
            }
            catch (DbUpdateConcurrencyException) 
            {   
                var usuarioValido= context.Usuario.FindAsync(id);
                if(usuarioValido == null)
                {
                    return NotFound();
                }else{
                    throw;
                }
            }
            return usuario;

            //return NoContent(); // (NoContent) Nenhum conteúdo a retornar
        }

        [HttpDelete ("{id}")]
        
        public async Task<ActionResult<Usuario>> Delete (int id) {
        
            Usuario usuarioRetornado = await context.Usuario.FindAsync (id);
        
            if (usuarioRetornado == null) {
        
                return NotFound ();
        
            }

            context.Usuario.Remove (usuarioRetornado);
            
            await context.SaveChangesAsync ();

            return usuarioRetornado;
        
        }
    }
}