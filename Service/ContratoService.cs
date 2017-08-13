using FinanceiroBus.DAO;
using FinanceiroBus.Model;

namespace FinanceiroBus.Service
{
    public class ContratoService
    {
        private ContratoDAO contratoDAO = new ContratoDAO();

        public bool Salvar(Contrato contrato)
        {
            if (ExisteContratoAtivo(contrato))
                return false;

            this.contratoDAO.Salvar(contrato);
            return true;
        }

        private bool ExisteContratoAtivo(Contrato contrato)
        {
            var contratosAtivados = contratoDAO.ListarAtivos();

            foreach (var contratoAtivo in contratosAtivados)
            {
                if (contratoAtivo.AlunoId == contrato.AlunoId)
                    return true;
            }

            return false;
        }
    }
}
