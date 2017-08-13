using System;

namespace FinanceiroBus.Model.Report
{
    public class Contrato
    {
        public long Id { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string PlanoPagamento { get; set; }
        public string SituacaoFinanceira { get; set; }
        public string Ativado { get; set; }
        public string Aluno { get; set; }
        public string InstituicaoEnsino { get; set; }
    }
}
