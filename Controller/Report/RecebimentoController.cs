using FinanceiroBus.DAO.Report;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;

namespace FinanceiroBus.Controller.Report
{
    public class RecebimentoController
    {
        private RecebimentoDAO recebimentoDAO = new RecebimentoDAO();

        public IList<Recebimento> Listar()
        {
            return this.recebimentoDAO.Listar();
        }
    }
}
