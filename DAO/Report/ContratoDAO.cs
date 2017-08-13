using FinanceiroBus.Context;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO.Report
{
    public class ContratoDAO
    {
        private EFContext context = new EFContext();
        public IList<Contrato> Listar()
        {
            var query = from c in context.Contratos.ToList()
                        select new Contrato
                        {
                            Id = c.Id,
                            DataInicial = c.DataInicial,
                            DataFinal = c.DataFinal,
                            PlanoPagamento = c.PlanoPagamento.ToString(),
                            SituacaoFinanceira = c.SituacaoFinanceira.ToString(),
                            Ativado = c.Ativado == true ? "SIM" : "NAO",
                            Aluno = c.Aluno.Nome,
                            InstituicaoEnsino = c.InstituicaoEnsino.Acronimo
                        };

            return query.ToList<Contrato>();
        }
    }
}
