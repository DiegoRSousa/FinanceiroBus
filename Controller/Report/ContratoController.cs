using FinanceiroBus.DAO.Report;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;

namespace FinanceiroBus.Controller.Report
{
    public class ContratoController
    {
        private ContratoDAO contratoDAO = new ContratoDAO();
        public IList<Contrato> Listar()
        {
            return contratoDAO.Listar();
        }
    }
}
