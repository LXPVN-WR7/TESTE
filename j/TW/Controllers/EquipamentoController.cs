using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TW.Models;
using TW.Repositorios;

namespace TW.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    [Produces("application/json")]

    public class EquipamentoController : ControllerBase 
    {
        EquipamentoRepositorio repositorio = new EquipamentoRepositorio();

        [HttpGet]

        public async Task<ActionResult<List<Equipamento>>> Get ()
        {
            try
            {
                return await repositorio.Get();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Equipamento>> Get (int id)
        {
            Equipamento equipamento = await repositorio.Get(id);

            if(equipamento == null){
                return NotFound();
            }
            return equipamento;
        }

        [HttpPost]

        public async Task<ActionResult<Equipamento>> Post (Equipamento equipamento)
        {
            try
            {
                await repositorio.Post(equipamento);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            return equipamento;
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Equipamento>> Put (int id, Equipamento equipamento)
        {
            if(id != equipamento.IdEquipamento){
                return BadRequest();
            }
            try
            {
                return await repositorio.Put(equipamento);
            }
            catch (System.Exception)
            {
                var equipamentoValido = await repositorio.Get(id);
                if(equipamentoValido == null){
                    return NotFound();
                }else{
                    throw;
                }
                throw;
            }
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Equipamento>> Delete (int id)
        {
            Equipamento equipamento = await repositorio.Get(id);

            if(equipamento == null){

                return NotFound();
            
            }

            await repositorio.Delete(equipamento);

            return equipamento;
        }

    }
}