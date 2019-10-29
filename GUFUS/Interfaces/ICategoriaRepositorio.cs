using System.Collections.Generic;
using System.Threading.Tasks;
using GUFUS.Models;
using Microsoft.AspNetCore.Mvc;

namespace GUFUS.Interfaces
{
    public interface ICategoriaRepositorio
    {
         Task<List<Categoria>> Get();

         Task<Categoria> Get(int id);

         Task<Categoria> Post (Categoria categoria);

         Task<Categoria> Put(int id, Categoria categoria);

         Task<Categoria> Delete(int id);  


    }
}