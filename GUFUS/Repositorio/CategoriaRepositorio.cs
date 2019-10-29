using System.Collections.Generic;
using System.Threading.Tasks;
using GUFUS.Interfaces;
using GUFUS.Models;
using Microsoft.EntityFrameworkCore;

namespace GUFUS.Repositorio {
    public class CategoriaRepositorio : ICategoriaRepositorio {
        GufosContext context = new GufosContext ();

        public async Task<List<Categoria>> Get () {
            return await context.Categoria.ToListAsync ();
        }

        public async Task<Categoria> Get (int id) {
            return await context.Categoria.FindAsync (id);
        }

        public async Task<Categoria> Post (Categoria categoria) {
            
            await context.Categoria.AddAsync(categoria);

            await context.SaveChangesAsync ();

            return categoria;
        
        }

        public async Task<Categoria> Put (int id, Categoria categoria) {

        Categoria categoriaRetornada = await context.Categoria.FindAsync (id);

        return categoriaRetornada;

        }

        public Task<Categoria> Delete (int id) {
            throw new System.NotImplementedException ();
        }
    }
}