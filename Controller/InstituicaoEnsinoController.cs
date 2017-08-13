using FinanceiroBus.DAO;
using FinanceiroBus.Model;
using System.Collections.Generic;

namespace FinanceiroBus.Controller
{
    public class InstituicaoEnsinoController
    {
        InstituicaoEnsinoDAO instituicaoEnsinoDAO = new InstituicaoEnsinoDAO();

        public void Salvar(InstituicaoEnsino isntituicaoEnsino)
        {
            instituicaoEnsinoDAO.Salvar(isntituicaoEnsino);
        }

        public void Atualizar(InstituicaoEnsino instituicaoEnsino)
        {
            instituicaoEnsinoDAO.Atualizar(instituicaoEnsino);
        }

        public IList<InstituicaoEnsino> Listar()
        {
            return instituicaoEnsinoDAO.Listar();
        }

        public void Excluir(long idInstituicaoEnsino)
        {
            instituicaoEnsinoDAO.Excluir(idInstituicaoEnsino);
        }

        public IList<InstituicaoEnsino> PorAcronimo(string acronimo)
        {
            return instituicaoEnsinoDAO.PorAcronimo(acronimo);
        }
    }
}
