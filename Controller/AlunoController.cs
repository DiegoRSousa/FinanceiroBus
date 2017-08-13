using FinanceiroBus.DAO;
using FinanceiroBus.Model;
using System.Collections.Generic;

namespace FinanceiroBus.Controller
{
    public class AlunoController
    {
        AlunoDAO alunoDAO = new AlunoDAO();

        public Aluno PorId(long alunoId)
        {
            return this.alunoDAO.PorId(alunoId);
        }

        public void Salvar(Aluno aluno)
        {
            this.alunoDAO.Salvar(aluno);
        }

        public void Atualizar(Aluno aluno)
        {
            this.alunoDAO.Atualizar(aluno);
        }

        public IList<Aluno> Listar()
        {
            return this.alunoDAO.Listar();
        }

        public void Excluir(long idAluno)
        {
            this.alunoDAO.Excluir(idAluno);
        }

        public IList<Aluno> PorNome(string nome)
        {
            return this.alunoDAO.PorNome(nome);
        }
    }
}
