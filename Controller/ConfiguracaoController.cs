using FinanceiroBus.DAO;
using FinanceiroBus.Model;

namespace FinanceiroBus.Controller
{
    public class ConfiguracaoController
    {
        private ConfiguracaoDAO configuracaoDAO = new ConfiguracaoDAO();

        public void Salvar(Configuracao configuracao)
        {
            this.configuracaoDAO.Salvar(configuracao);
        }

        public Configuracao Configuracao()
        {
            return this.configuracaoDAO.Configuracao();
        }

        public void Atualizar(Configuracao configuracao)
        {
            this.configuracaoDAO.Atualizar(configuracao);
        }
    }
}
