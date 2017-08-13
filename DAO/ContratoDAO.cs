using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO
{
    public class ContratoDAO
    {
        EFContext context = new EFContext();

        public void Salvar(Contrato contrato)
        {
            context.Contratos.Add(contrato);
            context.SaveChanges();
        }

        public IList<Contrato> Listar()
        {
            var x = context.Contratos.ToList<Contrato>();
            return x;
        }

        public void Desativar(long contratoId)
        {
            var novoContrato = context.Contratos.Find(contratoId);
            novoContrato.Ativado = false;
            context.SaveChanges();
        }

        public void Atualizar(Contrato contrato)
        {
            var novoContrato = context.Contratos.Find(contrato.Id);
            novoContrato.DataInicial = contrato.DataInicial;
            novoContrato.DataFinal = contrato.DataFinal;
            context.SaveChanges();
        }

        public IList<Contrato> PorNomeAluno(string nomeAluno)
        {
            var query = context.Contratos.Where(c => c.Aluno.Nome.Contains(nomeAluno));
            return query.ToList<Contrato>();
        }

        public Contrato PorIdAluno(long idAluno)
        {
            var query = ListarAtivos().Where(c => c.AlunoId.Equals(idAluno));
            return query.First<Contrato>();
        }

        public IList<Contrato> ListarAtivos()
        {
            var query = context.Contratos.Where(c => c.Ativado == true);
            return query.ToList<Contrato>();
        }
    }
}
