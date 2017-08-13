using FinanceiroBus.Model;
using System;
using System.Net;
using System.Net.Mail;

namespace FinanceiroBus.Service
{
    public class EmailService
    {
        public static bool EnviarEmail(string destinatario, string assunto, string mensagem, Configuracao configuracao)
        {
            try
            {
                using (SmtpClient client = new SmtpClient(configuracao.SMTP, configuracao.Porta)
                {
                    Credentials = new NetworkCredential(configuracao.Email, configuracao.Senha),
                    EnableSsl = true
                })
                {
                    client.Send(configuracao.Email, destinatario, assunto, mensagem);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
