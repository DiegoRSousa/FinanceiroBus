using System;

namespace FinanceiroBus.Model
{
    public class Pagamento
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public long ContaAPagarId { get; set; }
        public virtual ContaAPagar ContaAPagar { get; set; }
        public bool Cancelado { get; set; }
    }
}
