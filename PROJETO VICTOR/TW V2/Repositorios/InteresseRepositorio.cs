using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TW.Infertaces;
using TW.Models;

namespace TW.Repositorios
{
    public class InteresseRepositorio : IInteresseRepositorio
    {
        TwContext context = new TwContext();
        public async Task<Interesse> Delete(Interesse interesseRetornado)
        {
            context.Interesse.Remove(interesseRetornado);
            await context.SaveChangesAsync();
            return interesseRetornado;
        }
        public async Task<List<Interesse>> Get()
        {
           var resultado = context.Interesse.Include(usr => usr.IdUsuarioNavigation).Include(prod => prod.IdClassificadoNavigation.IdEquipamentoNavigation).ToListAsync();
           return await resultado;
        }
        public async Task<Interesse> Get(int id)
        {
          return await context.Interesse.FindAsync(id);
        }
        public async Task<Interesse> Post(Interesse interesse)
        {
            await context.Interesse.AddAsync(interesse);
            await context.SaveChangesAsync();
            return interesse;
        }
        public async Task<Interesse> Put(Interesse interesse)
        {
            context.Entry(interesse).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return interesse;
        }
    }
}