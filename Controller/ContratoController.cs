using FinanceiroBus.DAO;
using FinanceiroBus.Model;
using FinanceiroBus.Service;
using System.Collections.Generic;

namespace FinanceiroBus.Controller
{
    public class ContratoController
    {
        private ContratoDAO contratoDAO = new ContratoDAO();
        private ContratoService contratoService = new ContratoService();

        public bool Salvar(Contrato contrato)
        {
            return this.contratoService.Salvar(contrato);
        }

        public IList<Contrato> Listar()
        {
            return this.contratoDAO.Listar();
        }

        public void Desativar(long contratoId)
        {
            this.contratoDAO.Desativar(contratoId);
        }

        public void Atualizar(Contrato contrato)
        {
            this.contratoDAO.Atualizar(contrato);
        }

        public IList<Contrato> PorNomeAluno(string nomeAluno)
        {
            return this.contratoDAO.PorNomeAluno(nomeAluno);
        }

        public Contrato PorIdAluno(long idAluno)
        {
            return this.contratoDAO.PorIdAluno(idAluno);
        }

        public IList<Contrato> ListarAtivos()
        {
            return this.contratoDAO.ListarAtivos();
        }
    }
}
