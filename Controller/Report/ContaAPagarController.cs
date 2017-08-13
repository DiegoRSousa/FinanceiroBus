using FinanceiroBus.DAO.Report;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;

namespace FinanceiroBus.Controller.Report
{
    public class ContaAPagarController
    {
        private ContaAPagarDAO contaAPagarDAO = new ContaAPagarDAO();
        public IList<ContaAPagar> Listar()
        {
            return contaAPagarDAO.Listar();
        }
    }
}
