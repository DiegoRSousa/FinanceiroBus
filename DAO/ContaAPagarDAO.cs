using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace FinanceiroBus.DAO
{
    public class ContaAPagarDAO
    {
        private EFContext context = new EFContext();

        public ContaAPagar PorId(long id)
        {
            return this.context.ContasAPagar.Find(id);
        }

        public void Salvar(ContaAPagar contaAPagar)
        {
            this.context.ContasAPagar.Add(contaAPagar);
            this.context.SaveChanges();
        }

        public void Cancelar(long id)
        {
            var novaContaAPagar = PorId(id);
            novaContaAPagar.Cancelada = true;
            this.context.SaveChanges();
        }

        public void Atualizar(ContaAPagar contaAPagar)
        {
            var novaContaAPagar = PorId(contaAPagar.Id);
            novaContaAPagar.Referencia = contaAPagar.Referencia;
            novaContaAPagar.Competencia = contaAPagar.Competencia;
            novaContaAPagar.Vencimento = contaAPagar.Vencimento;
            this.context.SaveChanges();
        }

        public IList<ContaAPagar> Listar()
        {
            return this.context.ContasAPagar.ToList<ContaAPagar>();
        }

        internal IList<ContaAPagar> PorNomeFavorecido(string nomeFavorecido)
        {
            var query = this.context.ContasAPagar.Where(c => c.Favorecido.Nome.Contains(nomeFavorecido));
            return query.ToList<ContaAPagar>();
        }

        public IList<ContaAPagar> PorNomeFavorecidoNaoLiquidadaNaoCancelada(string nomeFavorecido)
        {
            var query = this.context.ContasAPagar.Where(
                c => c.Favorecido.Nome.Contains(nomeFavorecido) && c.Status != Status.LIQUIDADO
                && c.Cancelada == false);
            return query.ToList<ContaAPagar>();
        }

        public void AtualizarStatus(ContaAPagar contaAPagar, Status status)
        {
            var novaContaAPagar = PorId(contaAPagar.Id);
            novaContaAPagar.Status = status;
            this.context.SaveChanges();
        }
    }
}
