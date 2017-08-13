using System;

namespace FinanceiroBus.Model
{
    public class ContaAReceber
    {
        public long Id { get; set; }
        public long ContratoId { get; set; }
        public virtual Contrato Contrato { get; set; }
        public string Referencia { get; set; }
        public DateTime Competencia { get; set; }
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }
        public Status Status { get; set; }
        public bool Cancelada { get; set; }
    }
}