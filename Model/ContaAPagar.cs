using System;

namespace FinanceiroBus.Model
{
    public class ContaAPagar
    {
        public long Id { get; set; }
        public virtual Favorecido Favorecido { get; set; }
        public long FavorecidoId { get; set; }
        public string Referencia { get; set; }
        public DateTime Competencia { get; set; }
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }
        public Status Status { get; set; }
        public bool Cancelada { get; set; }
    }
}
