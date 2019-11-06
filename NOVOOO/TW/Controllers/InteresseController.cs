using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TW.Models;
using TW.Repositorios;
using TW.Utils;

namespace TW.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    [Produces ("application/json")]

    public class InteresseController : ControllerBase {
        InteresseRepositorio repositorio = new InteresseRepositorio ();
        Validacoes validacoes = new Validacoes ();

        [HttpGet]
        public async Task<ActionResult<List<Interesse>>> Get () //definição do tipo de retorno
        {
            try {
                List<Interesse> lstInteresse = await repositorio.Get ();

                foreach (var item in lstInteresse) {
                    item.IdClassificadoNavigation.Interesse = null;
                }

                return lstInteresse;
                //await vai esperar traser a lista para armazenar em Categoria
            } catch (System.Exception) {
                throw;
            }

        }

        [HttpGet ("{id}")]
        public async Task<ActionResult<Interesse>> GetAction (int id) {
            Interesse interesseRetornado = await repositorio.Get (id);
            if (interesseRetornado == null) {
                return NotFound ();
            }
            return interesseRetornado;
        }

        [HttpPost]
        public async Task<ActionResult<Interesse>> Post (Interesse interesse) //tipo do objeto que está sendo enviado (Categoria) - nome que você determina pro objeto
        {
            try {
                await repositorio.Post (interesse);
            } catch (System.Exception) {
                throw;
            }
            return interesse;
        }

        [HttpPut ("{id}")]
        public async Task<ActionResult<Interesse>> Put (int id, Interesse interesse) {
            if (id != interesse.IdInteresse) {
                return BadRequest ();
            }

            try {

                var x = await repositorio.Put (interesse);

                string titulo = $"Parabéns {interesse.IdUsuarioNavigation.NomeCompleto} você foi selecionado - Você acaba de adquirir {interesse.IdClassificadoNavigation.IdEquipamentoNavigation.NomeEquipamento}";
                // Construct the alternate body as HTML.

                var corpo = Convert.ToString(Process.Start($@"..\ConteudoEmail.html"));
                string anexo = @"C:\Users\fic\Desktop\apostila.pdf";

                List<Interesse> lstInteresse = await repositorio.Get ();

                foreach (var item in lstInteresse) {
                    if (item.Comprador == false) {
                        validacoes.EnvioEmail (item.IdUsuarioNavigation.Email, titulo, corpo, anexo);
                    }
                }

                return x;

            } catch (DbUpdateConcurrencyException) {
                var interesseValido = await repositorio.Get (id);
                if (interesseValido == null) {
                    return NotFound ();
                } else {
                    throw;
                }
            }
        }

        [HttpDelete ("{id}")]
        public async Task<ActionResult<Interesse>> Delete (int id) {
            Interesse interesseRetornado = await repositorio.Get (id);
            if (interesseRetornado == null) {
                return NotFound ();
            }
            await repositorio.Delete (interesseRetornado);
            return interesseRetornado;
        }
    }
}