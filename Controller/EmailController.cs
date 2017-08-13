using FinanceiroBus.Model;
using FinanceiroBus.Service;

namespace FinanceiroBus.Controller
{
    public class EmailController
    {
        public static bool EnviarEmail(string destinatario, string assunto, string mensagem, Configuracao configuracao)
        {
            return EmailService.EnviarEmail(destinatario, assunto, mensagem, configuracao);
        }
    }
}
