using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO
{
    public class ContaAReceberDAO
    {
        EFContext context = new EFContext();

        public ContaAReceber PorId(long id)
        {
            return this.context.ContasAReceber.Find(id);
        }

        public void Salvar(ContaAReceber contaAReceber)
        {
            this.context.ContasAReceber.Add(contaAReceber);
            this.context.SaveChanges();
        }

        public IList<ContaAReceber> Listar()
        {
            return this.context.ContasAReceber.ToList<ContaAReceber>();
        }

        public void Cancelar(long id)
        {
            var novaContaAReceber = PorId(id);
            novaContaAReceber.Cancelada = true;
            this.context.SaveChanges();
        }

        public IList<ContaAReceber> PorNomeAluno(string nomeAluno)
        {
            var query = this.context.ContasAReceber.Where(c => c.Contrato.Aluno.Nome.Contains(nomeAluno));
            return query.ToList<ContaAReceber>();
        }

        public IList<ContaAReceber> PorNomeAlunoNaoLiquidadaNaoCancelada(string nomeAluno)
        {
            var query = this.context.ContasAReceber.Where(
                c => c.Contrato.Aluno.Nome.Contains(nomeAluno) && c.Status != Status.LIQUIDADO
                && c.Cancelada == false);
            return query.ToList<ContaAReceber>();
        }

        public void Atualizar(ContaAReceber contaAReceber)
        {
            var novaContaAReceber = PorId(contaAReceber.Id);
            novaContaAReceber.Referencia = contaAReceber.Referencia;
            novaContaAReceber.Competencia = contaAReceber.Competencia;
            novaContaAReceber.Vencimento = contaAReceber.Vencimento;
            this.context.SaveChanges();
        }

        public void AtualizarStatus(ContaAReceber contaAReceber, Status status)
        {
            var novaContaAReceber = PorId(contaAReceber.Id);
            novaContaAReceber.Status = status;
            this.context.SaveChanges();
        }
    }
}
