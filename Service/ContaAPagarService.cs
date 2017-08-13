using FinanceiroBus.DAO;
using FinanceiroBus.Model;
using System;

namespace FinanceiroBus.Service
{
    public class ContaAPagarService
    {
        private ContaAPagarDAO contaAPagarDAO = new ContaAPagarDAO();

        public bool Cancelar(long id)
        {
            var contaAPagar = this.contaAPagarDAO.PorId(id);
            if(contaAPagar.Status == Status.EM_ABERTO)
            {
                this.contaAPagarDAO.Cancelar(id);
                return true;
            }
            return false;
            
        }
    }
}
