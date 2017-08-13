using FinanceiroBus.Context;
using FinanceiroBus.Model;
using System.Collections.Generic;
using System.Linq;

namespace FinanceiroBus.DAO
{
    public class AlunoDAO
    {
        private EFContext context = new EFContext();

        public Aluno PorId(long alunoId)
        {
            return this.context.Alunos.Find(alunoId);
        }

        public void Salvar(Aluno aluno)
        {
            context.Alunos.Add(aluno);
            context.SaveChanges();
        }

        public void Atualizar(Aluno aluno)
        {
            var novoAluno = PorId(aluno.Id);
            novoAluno.Nome = aluno.Nome;
            novoAluno.Telefone = aluno.Telefone;
            novoAluno.Email = aluno.Email;
            novoAluno.Matricula = aluno.Matricula;
            context.SaveChanges();
        }

        public IList<Aluno> Listar()
        {
            return context.Alunos.ToList<Aluno>();
        }

        public void Excluir(long idAluno)
        {
            var aluno = PorId(idAluno);
            context.Alunos.Remove(aluno);
            context.SaveChanges();
        }

        public IList<Aluno> PorNome(string nome)
        {
            var query = context.Alunos.Where(a => a.Nome.Contains(nome));
            return query.ToList<Aluno>();
        }
    }
}
