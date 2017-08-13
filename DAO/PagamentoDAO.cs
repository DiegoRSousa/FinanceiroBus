using System;
using System.Collections.Generic;
using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System.Linq;

namespace FinanceiroBus.DAO
{
    public class PagamentoDAO
    {
        private EFContext context = new EFContext();

        public Pagamento PorId(int id)
        {
            return this.context.Pagamentos.Find(id);
        }

        public void Salvar(Pagamento pagamento)
        {
            this.context.Pagamentos.Add(pagamento);
            this.context.SaveChanges();
        }

        public void Cancelar(int id)
        {
            var novoPagamento = PorId(id);
            novoPagamento.Cancelado = true;
            this.context.SaveChanges();
        }

        public IList<Pagamento> PorNomeFavorecido(string nomeFavorecido)
        {
            var query = this.context.Pagamentos.Where(p => p.ContaAPagar.Favorecido.Nome.Contains(nomeFavorecido));
            return query.ToList<Pagamento>();
        }

        internal IList<Pagamento> Listar()
        {
            return this.context.Pagamentos.ToList<Pagamento>();
        }
    }
}
