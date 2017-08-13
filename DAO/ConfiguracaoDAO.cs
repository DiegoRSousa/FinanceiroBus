using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System;
using System.Linq;

namespace FinanceiroBus.DAO
{
    public class ConfiguracaoDAO
    {
        private EFContext context = new EFContext();

        public void Salvar(Configuracao configuracao)
        {
            this.context.Configuracoes.Add(configuracao);
            this.context.SaveChanges();
        }

        public Configuracao Configuracao()
        {
            try
            {
                return this.context.Configuracoes.First<Configuracao>();
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        public void Atualizar(Configuracao configuracao)
        {
            var novaConfiguracao = context.Configuracoes.Find(configuracao.Id);
            novaConfiguracao.Email = configuracao.Email;
            novaConfiguracao.Senha = configuracao.Senha;
            novaConfiguracao.SMTP = configuracao.SMTP;
            novaConfiguracao.Porta = configuracao.Porta;
            context.SaveChanges();
        }
    }
}
