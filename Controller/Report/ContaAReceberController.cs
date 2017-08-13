using FinanceiroBus.DAO.Report;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;

namespace FinanceiroBus.Controller.Report
{
    public class ContaAReceberController
    {
        private ContaAReceberDAO contaAReceberDAO = new ContaAReceberDAO();

        public IList<ContaAReceber> Listar()
        {
            return this.contaAReceberDAO.Listar();
        }
    }
}
