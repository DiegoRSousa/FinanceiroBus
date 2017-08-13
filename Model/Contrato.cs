using System;
using System.Collections.Generic;

namespace FinanceiroBus.Model
{
    public class Contrato
    {
        public long Id { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public PlanoPagamento PlanoPagamento { get; set; }
        public SituacaoFinanceira SituacaoFinanceira { get; set; }
        public bool Ativado { get; set; }
        public long AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
        public long InstituicaoEnsinoId { get; set; }
        public virtual InstituicaoEnsino InstituicaoEnsino { get; set; }

        public virtual IList<ContaAReceber> ContasAReceber { get; set; }

        public Contrato()
        {
            SituacaoFinanceira = SituacaoFinanceira.EM_DIA;
        }
    }
}
