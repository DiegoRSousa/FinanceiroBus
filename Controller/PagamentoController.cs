using FinanceiroBus.Model;
using FinanceiroBus.DAO;
using System;
using System.Collections.Generic;

namespace FinanceiroBus.Controller
{
    public class PagamentoController
    {
        private PagamentoDAO pagamentoDAO = new PagamentoDAO();

        public Pagamento PorId(int id)
        {
            return pagamentoDAO.PorId(id);
        }

        public void Salvar(Pagamento pagamento)
        {
            pagamentoDAO.Salvar(pagamento);
        }

        public void Cancelar(int id)
        {
            this.pagamentoDAO.Cancelar(id);
        }

        public IList<Pagamento> PorNomeFavorecido(string nomeFavorecido)
        {
            return this.pagamentoDAO.PorNomeFavorecido(nomeFavorecido);
        }

        public IList<Pagamento> Listar()
        {
            return this.pagamentoDAO.Listar();
        }
    }
}
