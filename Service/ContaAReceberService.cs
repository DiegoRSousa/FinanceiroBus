using FinanceiroBus.DAO;
using FinanceiroBus.Model;

namespace FinanceiroBus.Service
{
    public class ContaAReceberService
    {
        private ContaAReceberDAO contaAReceberDAO = new ContaAReceberDAO();

        public bool Cancelar(long id)
        {
            var contaAReceber = this.contaAReceberDAO.PorId(id);

            if (contaAReceber.Status == Status.EM_ABERTO)
            {
                this.contaAReceberDAO.Cancelar(id);
                return true;
            }
            return false;
        }
    }
}
