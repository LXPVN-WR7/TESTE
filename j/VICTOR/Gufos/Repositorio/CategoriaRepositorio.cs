using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gufos.Interfaces;
using Gufos.Models;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        GufosContext context = new GufosContext();

        public async Task<List<Categoria>> Get()
        {
            return await context.Categoria.ToListAsync();
        }



        public Task<Categoria> Delete(int id)
        {
            throw new System.NotImplementedException();
        }


        public async Task<Categoria> Get(int id)
        {
           return await context.Categoria.FindAsync(id);
        }




        public async Task<Categoria> Post(Categoria categoria)
        {
          
             await context.Categoria.AddAsync(categoria);
             await context.SaveChangesAsync();

             return categoria;
        }

        public async Task<Categoria> Put(int id, Categoria categoria)
        {
              context.Entry(categoria).State = EntityState.Modified;
              await context.SaveChangesAsync();

              return categoria;
        }
    }
}