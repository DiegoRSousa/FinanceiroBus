using FinanceiroBus.DAO;
using FinanceiroBus.Model;
using System.Collections.Generic;

namespace FinanceiroBus.Controller
{
    public class RecebimentoController
    {
        private RecebimentoDAO recebimentoDAO = new RecebimentoDAO();

        public void Salvar(Recebimento recebimento)
        {
            this.recebimentoDAO.Salvar(recebimento);
        }

        public IList<Recebimento> Listar()
        {
            return this.recebimentoDAO.Listar();
        }

        public void Cancelar(int id)
        {
            this.recebimentoDAO.Cancelar(id);
        }

        public Recebimento PorId(int id)
        {
            return this.recebimentoDAO.PorId(id);
        }

        public IList<Recebimento> PorNomeAluno(string nome)
        {
            return this.recebimentoDAO.PorNomeAluno(nome);
        }
    }
}
