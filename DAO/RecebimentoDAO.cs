using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO
{
    public class RecebimentoDAO
    {
        EFContext context = new EFContext();

        public Recebimento PorId(int id)
        {
            return this.context.Recebimentos.Find(id);
        }

        public void Salvar(Recebimento recebimento)
        {
            this.context.Recebimentos.Add(recebimento);
            this.context.SaveChanges();
        }

        public IList<Recebimento> Listar()
        {
            return this.context.Recebimentos.ToList<Recebimento>();
        }

        public void Cancelar(int id)
        {
            var novoRecebimento = PorId(id);
            novoRecebimento.Cancelado = true;
            this.context.SaveChanges();
        }

        public IList<Recebimento> PorNomeAluno(string nome)
        {
            var query = context.Recebimentos.Where(r => r.ContaAReceber.Contrato.Aluno.Nome.Contains(nome));
            return query.ToList<Recebimento>();
        }
    }
}
