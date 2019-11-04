using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using EnvioDeEmails.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnvioDeEmails {

    [Route ("api/[controller]")]

    [ApiController]

    [Produces ("application/json")]


    public class EnvioDeEmails {
    
        TwContext context = new TwContext();

        [HttpPost]

        public async Task<ActionResult<String>> Post () {

            try {
                string emailDestinatario = "lightcodexp@gmail.com";
                SendMail (emailDestinatario);
                return emailDestinatario;

            } catch (System.Exception) {

                throw;
            }
        }

        public bool SendMail (string email) {
            try {
                // Estancia da Classe de Mensagem
                MailMessage _mailMessage = new MailMessage ();
                // Remetente
                _mailMessage.From = new MailAddress ("lxpvnwr7@gmail.com");

                // Destinatario seta no metodo abaixo

                //Contrói o MailMessage
                _mailMessage.CC.Add (email);
                _mailMessage.Subject = "TESTELIGHT CODE XP";
                _mailMessage.IsBodyHtml = true;
                _mailMessage.Body = "<b>Olá Tudo bem ??</b><p>Teste Parágrafo</p>";

                //CONFIGURAÇÃO COM PORTA
                SmtpClient _smtpClient = new SmtpClient ("smtp.gmail.com", Convert.ToInt32 ("587"));

                //CONFIGURAÇÃO SEM PORTA

                // SmtpClient _smtpClient = new SmtpClient(UtilRsource.ConfigSmtp);

                // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação);

                _smtpClient.UseDefaultCredentials = false;

                _smtpClient.Credentials = new NetworkCredential ("lxpvnwr7@gmail.com", "0736867444@");

                _smtpClient.EnableSsl = true;

                _smtpClient.Send (_mailMessage);

                return true;

            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}