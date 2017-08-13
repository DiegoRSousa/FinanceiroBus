using FinanceiroBus.Context;
using FinanceiroBus.Model.Report;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO.Report
{
    public class ContaAReceberDAO
    {
        private EFContext context = new EFContext();

        public IList<ContaAReceber> Listar()
        {
            var query = from c in context.ContasAReceber.ToList()
                        select new ContaAReceber
                        {
                            Id = c.Id,
                            Aluno = c.Contrato.Aluno.Nome,
                            Competencia = c.Competencia,
                            Vencimento = c.Vencimento,
                            Valor = c.Valor,
                            Status = c.Status.ToString(),
                            DiasParaVencimento = c.Status == Model.Status.EM_ABERTO ? Convert.ToInt16(c.Vencimento.Subtract(DateTime.Now).TotalDays) : 0,
                            Cancelada = c.Cancelada == true ? "SIM" : "NAO"
                        };

            return query.ToList<ContaAReceber>();
        }
    }
}
