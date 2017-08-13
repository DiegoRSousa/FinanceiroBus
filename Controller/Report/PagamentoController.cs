using FinanceiroBus.DAO.Report;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;

namespace FinanceiroBus.Controller.Report
{
    public class PagamentoController
    {
        private PagamentoDAO pagamentoDAO = new PagamentoDAO();

        public IList<Pagamento> Listar()
        {
            return this.pagamentoDAO.Listar();
        }

    }
}