using System;

namespace FinanceiroBus.Model.Report
{
    public class Recebimento
    {
        public long Id { get; set; }
        public string Aluno { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }
}
