using System;

namespace FinanceiroBus.Model.Report
{
    public class ContaAReceber
    {
        public long Id { get; set; }
        public string Aluno { get; set; }
        public DateTime Competencia { get; set; }
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }
        public string Status { get; set; }
        public int DiasParaVencimento { get; set; }
        public string Cancelada { get; set; }
    }
}
