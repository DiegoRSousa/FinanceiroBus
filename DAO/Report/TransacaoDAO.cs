using FinanceiroBus.Context;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO.Report
{
    public class TransacaoDAO
    {
        private EFContext context = new EFContext();
        public IList<Transacao> Listar()
        {
            var queryPagamento = from r in this.context.Recebimentos.ToList()
                        select new Transacao
                        {
                            Valor = r.Valor,
                            Data = r.Data
                        };
            var queryRecebimento = from p in this.context.Pagamentos.ToList()
                         select new Transacao
                         {
                             Valor = p.Valor * -1,
                             Data = p.Data
                         };
            var resultado = queryRecebimento.Concat(queryPagamento);
            return resultado.OrderBy(r => r.Data).ToList<Transacao>();
        }
    }
}
