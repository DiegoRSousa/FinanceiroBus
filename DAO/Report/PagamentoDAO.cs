using FinanceiroBus.Context;
using FinanceiroBus.Model.Report;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO.Report
{
    public class PagamentoDAO
    {
        private EFContext context = new EFContext();

        public IList<Pagamento> Listar()
        {
            var query = from p in this.context.Pagamentos.ToList()
                        select new Pagamento
                        {
                            Id = p.Id,
                            Favorecido = p.ContaAPagar.Favorecido.Nome,
                            Data = p.Data,
                            Valor = p.Valor
                        };
            return query.ToList<Pagamento>();
        }
    }
}
