using FinanceiroBus.DAO;
using FinanceiroBus.Model;
using FinanceiroBus.Service;
using System.Collections.Generic;

namespace FinanceiroBus.Controller
{
    public class ContaAReceberController
    {
        private ContaAReceberDAO contaAReceberDAO = new ContaAReceberDAO();
        private ContaAReceberService contaAReceberService = new ContaAReceberService();

        public ContaAReceber PorId(int id)
        {
            return this.contaAReceberDAO.PorId(id);
        }

        public void Salvar(ContaAReceber contaAReceber)
        {
            this.contaAReceberDAO.Salvar(contaAReceber);
        }

        public IList<ContaAReceber> Listar()
        {
            return this.contaAReceberDAO.Listar();
        }

        public bool Cancelar(long id)
        {
            return this.contaAReceberService.Cancelar(id);
        }

        public IList<ContaAReceber> PorNomeAluno(string nomeAluno)
        {
            return this.contaAReceberDAO.PorNomeAluno(nomeAluno);
        }

        public IList<ContaAReceber> PorNomeAlunoNaoLiquidadaNaoCancelada(string nomeAluno)
        {
            return this.contaAReceberDAO.PorNomeAlunoNaoLiquidadaNaoCancelada(nomeAluno);
        }

        public void Atualizar(ContaAReceber contaAReceber)
        {
            this.contaAReceberDAO.Atualizar(contaAReceber);
        }

        public void AtualizarStatus(ContaAReceber contaAReceber, Status status)
        {
            this.contaAReceberDAO.AtualizarStatus(contaAReceber, status);
        }
    }
}
