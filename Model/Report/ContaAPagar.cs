using System;

namespace FinanceiroBus.Model.Report
{
    public class ContaAPagar
    {
        public long Id { get; set; }
        public string  Favorecido { get; set; }
        public DateTime Competencia { get; set; }
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }
        public string Status { get; set; }
        public int DiasVencimento { get; set; }
        public string Cancelada { get; set; }
    }
}
