using FinanceiroBus.DAO.Report;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;

namespace FinanceiroBus.Controller.Report
{
    public class TransacaoController
    {
        private TransacaoDAO transacaoDAO = new TransacaoDAO();

        public IList<Transacao> Listar()
        {
            return this.transacaoDAO.Listar();
        }
    }
}
