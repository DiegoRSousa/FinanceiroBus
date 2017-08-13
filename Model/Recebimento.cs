using System;

namespace FinanceiroBus.Model
{
    public class Recebimento
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public long ContaAReceberId { get; set; }
        public virtual ContaAReceber ContaAReceber { get; set; }
        public bool Cancelado { get; set; }
    }
}
