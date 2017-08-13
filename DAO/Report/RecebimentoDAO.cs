using FinanceiroBus.Context;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO.Report
{
    public class RecebimentoDAO
    {
        private EFContext context = new EFContext();

        public IList<Recebimento> Listar()
        {
            var query = from r in context.Recebimentos.ToList()
                        select new Recebimento
                        {
                            Id = r.Id,
                            Aluno = r.ContaAReceber.Contrato.Aluno.Nome,
                            Data = r.Data,
                            Valor = r.Valor
                        };

            return query.ToList<Recebimento>();
        }
    }
}
