using System.Collections.Generic;
using System.Threading.Tasks;
using Gufos.Interfaces;
using Gufos.Models;
using Microsoft.EntityFrameworkCore;

namespace Gufos.Repositorio
{
    public class LocalizacaoRepositorio : ILocalizacaoRepositorio
    {
        GufosContext context = new GufosContext();
        public async Task<Localizacao> Alterar(Localizacao localizacao)
        {
            context.Entry(localizacao).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return localizacao;

        }

        public async Task<Localizacao> Delete(Localizacao localizacaoRetornada)
        {
            context.Localizacao.Remove(localizacaoRetornada);
            await context.SaveChangesAsync();
           return localizacaoRetornada;
        } 

        public async Task<List<Localizacao>> Get()
        {
           List<Localizacao> listaDeLocalizacao = await context.Localizacao.ToListAsync();

           return listaDeLocalizacao;
        }

        public async Task<Localizacao> Get(int id)
        {
            return await context.Localizacao.FindAsync(id);
        }

        public async Task<Localizacao> Post(Localizacao localizacao)
        {
             await context.Localizacao.AddAsync(localizacao);
             await context.SaveChangesAsync();

             return localizacao;
        }
    }
}