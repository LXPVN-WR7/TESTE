using System.Collections.Generic;
using System.Threading.Tasks;
using Gufos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gufos.Interfaces
{
    public interface ILocalizacaoRepositorio
    {
         Task<List<Localizacao>> Get();

         Task<Localizacao> Get(int id);

         Task<Localizacao> Post(Localizacao localizacao);

         Task<Localizacao> Alterar(Localizacao localizacao);

         Task<Localizacao> Delete(Localizacao localizacaoRetornada);
         
    }
}