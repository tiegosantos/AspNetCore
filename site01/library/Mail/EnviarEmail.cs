using site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
namespace site01.library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {

            string conteudo = string.Format("Nome: {0}<br /> E-mail: {1} <br /> Assunto: {2} <br /> Mensagem: {3}", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            //configurar  servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP , Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            // Mensagem de e-mail

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("tiego22@yahoo.com.br");
            mensagem.To.Add("tiego22@yahoo.com.br");
            mensagem.Subject = "Fomulário de contato";


            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Fomulário de contato</h1>"+ conteudo;
            
            smtp.Send(mensagem);
        
        }

    }
}
