using System;

namespace FinanceiroBus.Model.Report
{
    public class Pagamento
    {
        public long Id { get; set; }
        public string Favorecido { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }
}
