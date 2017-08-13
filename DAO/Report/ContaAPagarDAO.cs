using FinanceiroBus.Context;
using FinanceiroBus.Model.Report;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO.Report
{
    public class ContaAPagarDAO
    {
        private EFContext context = new EFContext();

        public IList<ContaAPagar> Listar()
        {
            var query = from c in context.ContasAPagar.ToList()
                        select new ContaAPagar
                        {
                            Id = c.Id,
                            Favorecido = c.Favorecido.Nome,
                            Competencia = c.Competencia,
                            Vencimento = c.Vencimento,
                            Valor = c.Valor,
                            Status = c.Status.ToString(),
                            DiasVencimento = c.Status == Model.Status.EM_ABERTO ? Convert.ToInt16(c.Vencimento.Subtract(DateTime.Now).TotalDays) : 0,
                            Cancelada = c.Cancelada == true ? "SIM" : "NAO"
                        };

            return query.ToList<ContaAPagar>();
        }
    }
}
