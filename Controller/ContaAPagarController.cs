using FinanceiroBus.DAO;
using FinanceiroBus.Model;
using FinanceiroBus.Service;
using System.Collections.Generic;
using System;

namespace FinanceiroBus.Controller
{
    public class ContaAPagarController
    {
        private ContaAPagarDAO contaAPagarDAO = new ContaAPagarDAO();
        private ContaAPagarService contaAPagarService = new ContaAPagarService();

        public ContaAPagar PorId(long id)
        {
            return this.contaAPagarDAO.PorId(id);
        }

        public void Salvar(ContaAPagar contaAPagar)
        {
            this.contaAPagarDAO.Salvar(contaAPagar);
        }

        public void Atualizar(ContaAPagar contaAPagar)
        {
            this.contaAPagarDAO.Atualizar(contaAPagar);
        }

        public IList<ContaAPagar> Listar()
        {
            return this.contaAPagarDAO.Listar();
        }

        public IList<ContaAPagar> PorNomeFavorecidoNaoLiquidadaNaoCancelada(string nomeFavorecido)
        {
            return this.contaAPagarDAO.PorNomeFavorecidoNaoLiquidadaNaoCancelada(nomeFavorecido);
        }

        public IList<ContaAPagar> PorNomeFavorecido(string nomeFavorecido)
        {
            return this.contaAPagarDAO.PorNomeFavorecido(nomeFavorecido);
        }

        public bool Cancelar(long id)
        {
            return this.contaAPagarService.Cancelar(id);
        }

        public void AtualizarStatus(ContaAPagar contaAPagar, Status status)
        {
            this.contaAPagarDAO.AtualizarStatus(contaAPagar, status);
        }
    }
}
